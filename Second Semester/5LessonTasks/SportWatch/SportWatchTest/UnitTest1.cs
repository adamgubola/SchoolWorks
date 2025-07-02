using Moq;
using SportWatch;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportWatchTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void TimeTest()
        {
            Assert.Throws<TimeException>(() => { Time.Parse("10:10"); });

        }

        [Test]

        public void TimeTestMock()
        {
            
            Mock<Time> mock = new Mock<Time>("10:10:10");

            mock.Setup(x=> x.ToString()).Returns("10:10:10");

            Assert.That(mock.Object.ToString(),Is.EqualTo("10:10:10"));
            
        }

        [TestCase ("-1:10:10",typeof(HourException))]
        [TestCase("1:-10:10", typeof(MinuteException))]
        [TestCase("1:10:-10", typeof(SecondException))]


        public void TimeMinus(string expected, Type exception) 
        {
            Assert.Throws(exception, () => { Time temp = Time.Parse(expected); });
        }


        [TestCase("61:10:10", typeof(HourException))]
        [TestCase("1:61:10", typeof(MinuteException))]
        [TestCase("1:10:61", typeof(SecondException))]


        public void TimeOver(string expected, Type exception)
        {
            Assert.Throws(exception, () => { Time temp = Time.Parse(expected); });
        }

        [TestCase("Cycling,\"35.8\",\"1:28:03\",\"314\",\"142\"",false)]
        [TestCase("Cycling,\"35...8\",\"1:28:03\",\"314\",\"142\"", true)]
        [TestCase("Cycling,\"35.8\",\"1:28::::03\",\"314\",\"142\"", true)]
        [TestCase("Cycling,\"35.8\",\"1:28:03\",\",\"142\"", true)]


        public void workParseTest(string inp, bool exp)
        {
            if (exp) 
            {
                Assert.Throws<WorkoutException>(() => Workout.Parse(inp));
            }
            else
            {
                Assert.DoesNotThrow(() => Workout.Parse(inp));
            }
            
        }

        [Test]
                
        public void copyTest()

        {

            CsvProcessor processor = new CsvProcessor();

            processor.workouts= new Workout[]{
                                  new Workout("Cycling", 35.8, new Time("1:28:03"), 314, 142),
                                  null,
                                  new Workout("Cycling", 35.8, new Time("1:28:03"), 314, 142),
                                  null,
                                  new Workout("Cycling", 35.8, new Time("1:28:03"), 314, 142)};            ;


            Workout[] workouts2 = {new Workout("Cycling",35.8, new Time("1:28:03"), 314, 142),                                  
                                   new Workout("Cycling",35.8, new Time("1:28:03"), 314, 142),                                 
                                   new Workout("Cycling",35.8, new Time("1:28:03"), 314, 142)};

            
            Assert.That(processor.Copy(3, processor.workouts).Length, Is.EqualTo(workouts2.Length));
        }




    }
}