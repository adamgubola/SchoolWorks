using Zh_First;

namespace Zh_Firt_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(49, false, 200)]
        [TestCase(51, true, 400)]
        [TestCase(501, false, 1000)]
        [TestCase(1999, true, 1000)]

        public void CalculatePriceEnvelopeTest(int weight, bool fromLocker, int expected)
        {
            Envelope env = new Envelope(weight, "�d�m", "Lev�l");
            double temp = env.CalculatePrice(fromLocker);
            Assert.That(temp, Is.EqualTo(expected));
        }

        
        [TestCase(2001, false)]
        [TestCase(10000, true)]

        public void CalculatePriceExceptionTest(int weight, bool fromLocker)
        {
            IDeliverable env = new Envelope(weight, "�d�m", "Lev�l");
            Assert.Throws<OverweightException>(() => env.CalculatePrice(fromLocker));
        }

        [Test]
        public void FragileParcelArbitryTest()
        {

            Assert.Throws<IncorrectOrientationException>(() => new FragileParcel(1500, "Gy�ngy�s", EType.Arbitrary));

        }


        [TestCase(51, false, 1102)]
        [TestCase(1999, false, 4998)]

        public void CalculatePriceFragileTest(int weight, bool fromLocker, int expected)
        {
            IDeliverable frag = new FragileParcel(weight, "Gy�ngy�s", EType.Horizontal);
            double temp = frag.CalculatePrice(fromLocker);
            Assert.That(temp, Is.EqualTo(expected));
            
        }

        [TestCase(51, true, 1102)]
        [TestCase(1999, true, 4998)]

        public void CalculatePriceFragileExceptionTest(int weight, bool fromLocker, int expected)
        {
            IDeliverable frag = new FragileParcel(weight, "Gy�ngy�s", EType.Horizontal);
            
            Assert.Throws<DeliveryException>(()=> frag.CalculatePrice(fromLocker));

        }
        [Test]
        public void PickUpItemTest()
        {
            int res = 2600;

            Courier courier = new Courier(4);

            courier.PickUpItem(new NormalParcel(51, "Gy�ngy�s"));
            courier.PickUpItem(new NormalParcel(49, "Gy�ngy�s"));
            courier.PickUpItem(new NormalParcel(501, "Gy�ngy�s"));
            courier.PickUpItem(new NormalParcel(1999, "Gy�ngy�s"));

            Assert.That(res, Is.EqualTo(courier.AllWeight));
        }

        [Test]
        public void SortedItemTest()
        {
            int res = 3;

            Courier courier = new Courier(6);

            courier.PickUpItem(new NormalParcel(51, "Gy�ngy�s"));
            courier.PickUpItem(new FragileParcel(49, "Gy�ngy�s", EType.Horizontal));
            courier.PickUpItem(new FragileParcel(100, "Gy�ngy�s", EType.Horizontal));
            courier.PickUpItem(new NormalParcel(501, "Gy�ngy�s"));
            courier.PickUpItem(new FragileParcel(1000, "Gy�ngy�s", EType.Horizontal));
            courier.PickUpItem(new NormalParcel(1999, "Gy�ngy�s"));

            IDeliverable[] deliverable = new IDeliverable[6];

            deliverable= courier.FragilesSorted();

            Assert.That(res, Is.EqualTo(deliverable.Length));
        }


    }
}