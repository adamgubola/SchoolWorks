using ZH2Practice;

namespace ZH2_UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("01:01:01")]
        [TestCase("01:01")]
        public void CreateTimeSuccess(string inp)
        {
            Time time = Time.TimeParse (inp);
            Assert.That(time.ToString(), Is.EqualTo(inp));
        }

        [TestCase("-1:01:01")]
        [TestCase("61:01")]
        public void CreateTimeFail(string inp)
        {
            
            Assert.Throws<TimeException>(() => Time.TimeParse(inp));
        }

        [Test]
        public void TimeCompare()
        {
            Time time = Time.TimeParse("01:00:00");
            Time time2 = Time.TimeParse("01:00:01");

            Assert.That(time.CompareTo(time2), Is.EqualTo(1));
        }
        [Test]

        public void BetweenTest()
        {
            string[] inp = new string[] { "Jani, 01:01:01", "Jani, 01:01:10", "Jani, 01:01:20",
                                          "Jani, 01:01:30", "Jani, 01:01:40", "Jani, 01:01:50",
                                           "Jani, 01:02:01", "Jani, 01:02:10", "Jani, 01:02:20",
                                           "Jani, 01:02:50" };

            RaceResults raceResults = new RaceResults(10, inp);

            Time low = new Time(01, 01, 29);
            Time up = new Time(01, 02, 10);

            RunnerWithTime [] result = raceResults.Between(low, up);

            Assert.That(result.Length, Is.EqualTo(4));
                
      
        }

    }
}