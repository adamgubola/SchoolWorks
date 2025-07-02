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
    internal class YearlyCostsTests
    {
        [Test]
        public void LoadFromNonExistingDirectory()
        {
            Assert.Throws<DirectoryNotFoundException>(() => YearlyCosts.LoadFrom("non_existing_directory"));
        }

        [Test]
        public void LoadFromSuccessful()
        {
            Assert.DoesNotThrow(() => YearlyCosts.LoadFrom(@"..\..\..\csv_files"));

            YearlyCosts yearlyCosts = YearlyCosts.LoadFrom(@"..\..\..\csv_files");
            Assert.That(yearlyCosts.Costs.Length, Is.EqualTo(12));
            for (int i = 0; i < 2; ++i)
            {
                Assert.That(yearlyCosts.Costs, Is.Not.Null);
            }
        }


        [Test]

        public void MaxCostTest()
        {
            YearlyCosts yearlyCosts = YearlyCosts.LoadFrom(@"..\..\..\csv_files");
            MonthlyCosts monthly = yearlyCosts.MaxCost();
            Assert.That(monthly.Sum(), Is.EqualTo(65900));

        }

        [Test]

        public void MaxCostWhenTest()
        {
            YearlyCosts yearlyCosts = YearlyCosts.LoadFrom(@"..\..\..\csv_files");
            MonthlyCosts monthly = yearlyCosts.MaxCostWhen(TrainingType.Swimming);
            Assert.That(monthly.Sum(), Is.EqualTo(65900));

        }
        public bool WhenSwimming(TrainingCost training)
        {
            if (training.Type == TrainingType.Swimming)
            {
                return true;
            }
            return false;
        }

        [Test]
        public void SimilarTypeAndDescTest()
        {
            YearlyCosts yearlyCosts = YearlyCosts.LoadFrom(@"..\..\..\csv_files");

            TrainingCost[] trainingTCost = yearlyCosts.SimilarTypeAndDesc(
                                            yearlyCosts.Costs[0], yearlyCosts.Costs[1], WhenSwimming);

            Assert.That(trainingTCost.Length, Is.EqualTo(3));
        }

        [Test]
        public void SimilarTypeAndDescExceptionTest()
        {
            YearlyCosts yearlyCosts = YearlyCosts.LoadFrom(@"..\..\..\csv_files");


            Assert.Throws<ZeroLengthArrayException>(() => yearlyCosts.SimilarTypeAndDesc(
                                            yearlyCosts.Costs[1], yearlyCosts.Costs[2], WhenSwimming));
        }
        [Test]
        public void HowManyPerTypesTest()
        {
            YearlyCosts yearlyCosts = YearlyCosts.LoadFrom(@"..\..\..\csv_files");
            int[]temp= new int[(int)Enum.GetValues(typeof(TrainingType)).Length];

            temp = yearlyCosts.HowManyPerTypes();

            Assert.That(temp[0], Is.EqualTo(6));

        }

    }
}
