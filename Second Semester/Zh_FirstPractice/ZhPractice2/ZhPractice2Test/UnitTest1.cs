using ZhPractice2;

namespace ZhPractice2Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(49, true, 200.0)]
        [TestCase(499, true, 400.0)]
        [TestCase(1999, true, 1000.0)]

        public void CalculatePriceEnvelope(int weight, bool fromLocker, double res)
        {
            Envelope envelope = new Envelope(weight, "Gy�ngy�s", "Lev�l");

            Assert.That(res, Is.EqualTo(envelope.CalculatePrice(fromLocker)));
        }

        
        [TestCase(2001, true)]

        public void CalculatePriceEnvelopeException(int weight, bool fromLocker)
        {
            Envelope envelope = new Envelope(weight, "Gy�ngy�s", "Lev�l");

            Assert.Throws<OverweightException>(() =>envelope.CalculatePrice(fromLocker));
        }

        [TestCase(2001, true)]

        public void CalculatePriceFragileException(int weight, bool fromLocker)
        {
            FragileParcel fragile = new FragileParcel(weight, "Gy�ngy�s", EType.Horizontal);

            Assert.Throws<DeliveryException>(() => fragile.CalculatePrice(fromLocker));
        }

        [TestCase(2001, true)]

        public void CalculatePriceFragileExceptionArbitary(int weight, bool fromLocker)
        {

            Assert.Throws< IncorrectOrientationException> (() => new FragileParcel(weight, "Gy�ngy�s", EType.Arbitrary));
        }

        [Test]
      
        public void CouierPickItemTest()
        {
            int allWeight = 2050;
            Courier courier = new Courier(3);

            courier.PickUpItem(new Envelope(50, "Gy�ngy�s", "Lev�l"));
            courier.PickUpItem(new FragileParcel(500, "Gy�ngy�s", EType.Horizontal));
            courier.PickUpItem(new NormalParcel(1500, "Gy�ngy�s"));


            Assert.That(allWeight, Is.EqualTo(courier.AllWeight));
        }
         
        





        }
}