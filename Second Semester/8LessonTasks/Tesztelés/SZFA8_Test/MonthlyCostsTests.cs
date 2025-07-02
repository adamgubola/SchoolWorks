using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TrainingCosts;

namespace TrainingCostsTests
{
    [TestFixture]
    internal class MonthlyCostsTests
    {
        [Test]
        public void LoadFromNonExisting()
        {
            Assert.Throws<FileNotFoundException>(() => MonthlyCosts.LoadFrom("non_existing.csv"));
        }

        [Test]
        public void LoadFromEmpty()
        {
            MonthlyCosts februaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_02.csv");
            Assert.That(februaryCosts.TrainingCosts.Length, Is.EqualTo(0));
        }

        [Test]
        public void LoadFromSuccessful()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.TrainingCosts.Length, Is.EqualTo(6));
        }

        [Test]

        public void SumTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.Sum(), Is.EqualTo(65900));
        }

        [Test]

        public void SumWhenRunning() 
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.SumWhenCost(WhenRunning), Is.EqualTo(0));
        }

        public bool WhenRunning(TrainingCost training)
        {
            if (training.Type == TrainingType.Running) 
            {
            return true;
            }
            return false;
        }

        [Test]

        public void SumWhenTest() 
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.All(Type, TrainingType.Running), Is.EqualTo(false));
        }

        public bool Type(TrainingCost training, TrainingType type)
        {
            return training.Type == type;
        }

        [Test]
        public void IsThatSpentTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.IsFalse(januaryCosts.IsThatSpent(WhenRunning,2));
            Assert.IsTrue(januaryCosts.IsThatSpent(WhenCyclig, 3));
            Assert.IsTrue(januaryCosts.IsThatSpentFunc(Type, TrainingType.Cycling, 3));

        }

        public bool WhenCyclig(TrainingCost training)
        {
            if (training.Type == TrainingType.Cycling)
            {
                return true;
            }
            return false;
        }

        [Test]
        public void WhichSpent()
        {
            string temp = "Cycling,Cassette,2024.01.03,12600";
            TrainingCost training = TrainingCost.Parse(temp);

            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");

            Assert.That(januaryCosts.WhichSpent(WhenCyclig, 3), Is.EqualTo(training));

        }
        [Test]
        public void HowManySpentTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.HowMany(WhenCyclig), Is.EqualTo(3));
        }

        [Test]

        public void MaxTest() {

            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            Assert.That(januaryCosts.Max(), Is.EqualTo(15000));


        }

        [Test]

        public void MaxAllTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            int[]temp =januaryCosts.MaxAll();
            Assert.That(temp.Length, Is.EqualTo(1));

        }

        [Test]

        public void WhichMaxAllTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            int[] temp = januaryCosts.WhichMaxAll(WhenCyclig);
            Assert.That(temp.Length, Is.EqualTo(1));

        }

        [Test]

        public void WhichAllTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            int[]temp = januaryCosts.WhichAll(WhenCyclig);

            Assert.That(temp[0], Is.EqualTo(0));
            Assert.That(temp[1], Is.EqualTo(1));
            Assert.That(temp[2], Is.EqualTo(2));

        }

        [Test]

        public void OrderSpendsTest()
        {
            MonthlyCosts januaryCosts = MonthlyCosts.LoadFrom(@"..\..\..\csv_files\2024_01.csv");
            TrainingCost[]temp = januaryCosts.OrderSpends(WhenSwimming);

            Assert.That(temp[0].Type, Is.EqualTo(TrainingType.Swimming));
            Assert.That(temp[1].Type, Is.EqualTo(TrainingType.Swimming));
            Assert.That(temp[2].Type, Is.EqualTo(TrainingType.Swimming));
            Assert.That(temp[3].Type, Is.EqualTo(TrainingType.Cycling));
            Assert.That(temp[4].Type, Is.EqualTo(TrainingType.Cycling));
            Assert.That(temp[5].Type, Is.EqualTo(TrainingType.Cycling));


        }

        public bool WhenSwimming(TrainingCost training)
        {
            if (training.Type == TrainingType.Swimming)
            {
                return true;
            }
            return false;
        }


    }
}
