using Gubola_Adam_D0JE27_ZH2;

namespace Gubola_Adam_D0JE27_ZH2_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Csirke farhát;Food;1000;330", "Csirke farhát (1000 g, Food) : 330 Ft")]
        [TestCase("Tejföl 20%;Food;330;299", "Tejföl 20% (330 g, Food) : 299 Ft")]

        public void ShoppingItemParseTestSuccess(string inp, string exp)
        {
            ShoppingItem item = ShoppingItem.Parse(inp);

            Assert.That(item.ToString(), Is.EqualTo(exp));
        }

        [Test]

        public void SaleTotalPriceTest()
        {
            Sale sale = new Sale(4);
            sale.Shopping[0] = ShoppingItem.Parse("Csirke farhát;Food;1000;330");
            sale.Shopping[1] = ShoppingItem.Parse("Tejföl 20%;Drink;330;299");
            sale.Shopping[2] = ShoppingItem.Parse("Csirke farhát;Food;1000;330");
            sale.Shopping[3] = ShoppingItem.Parse("Tejföl 20%;Drink;330;299");

            int exp = sale.TotalPrice(foodType);

            Assert.That(exp, Is.EqualTo(660));
        }

        public bool foodType(ShoppingItem item)
        {

            return item.Category == ECategory.Food;
        }

        [Test]

        public void SaleHashTrueTest()
        {
            Sale sale = new Sale(4);
            sale.Shopping[0] = ShoppingItem.Parse("A;Food;1000;330");
            sale.Shopping[1] = ShoppingItem.Parse("B;Drink;330;299");
            sale.Shopping[2] = ShoppingItem.Parse("C;Food;1000;330");
            sale.Shopping[3] = ShoppingItem.Parse("D;Drink;330;299");

            ShoppingItem test = ShoppingItem.Parse("C;Food;1000;330");

            bool res = sale.HasItem(test);

            Assert.That(res, Is.True);
        }

        [Test]

        public void SaleHashFalseTest()
        {
            Sale sale = new Sale(4);
            sale.Shopping[0] = ShoppingItem.Parse("A;Food;1000;330");
            sale.Shopping[1] = ShoppingItem.Parse("B;Drink;330;299");
            sale.Shopping[2] = ShoppingItem.Parse("C;Food;1000;330");
            sale.Shopping[3] = ShoppingItem.Parse("D;Drink;330;299");

            ShoppingItem test = ShoppingItem.Parse("G;Food;1000;330");

            bool res = sale.HasItem(test);

            Assert.That(res, Is.False);
        }
    }
}