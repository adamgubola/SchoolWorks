using Moq;
using Task5;

namespace Task5_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FoodIngredientToString_Test()
        {
            FoodIngredient foodIngredient = new FoodIngredient("Tej", 3, Units.liter);
            string temp = foodIngredient.ToString();    

            Assert.That(temp, Is.EqualTo("Név: Tej, Mennyiség: 3, Egység: liter"));
        }

        [TestCase (0)]
        public void IngredientStackEmpty_Empty(int num )
        {
            IngredientStack ingredientStack = new IngredientStack(num);

            bool temp = ingredientStack.Empty();

            Assert.That(temp, Is.True);
        }

        [TestCase(2)]
        public void IngredientStackEmpty_NotEmpty(int num)
        {
            IngredientStack ingredientStack = new IngredientStack(num);
            ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter));
            ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter));


            bool temp = ingredientStack.Empty();

            Assert.That(temp, Is.False);
        }

        [TestCase(2)]
        public void IngredientStackPush_(int num)
        {
            IngredientStack ingredientStack = new IngredientStack(num);
            ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter));
            ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter));
           

            Assert.Throws<StackFullException>(() => ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter)));

        }

        [TestCase(0)]
        public void IngredientStackPop_(int num)
        {
            IngredientStack ingredientStack = new IngredientStack(num);
          
            Assert.Throws<StackEmptyException>(()=>  ingredientStack.Pop());   
        }

        [TestCase(0)]
        public void IngredientStackTop_(int num)
        {
            IngredientStack ingredientStack = new IngredientStack(num);

            Assert.Throws<StackEmptyException>(() => ingredientStack.Top());
        }

        [TestCase(2)]
        public void IngredientStackPopFirstElement_(int num)
        {
            IngredientStack ingredientStack = new IngredientStack(num);
            ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter));
            ingredientStack.Push(new FoodIngredient("Tej", 3, Units.liter));

            FoodIngredient temp = ingredientStack.FoodIngredients[1];
            FoodIngredient res = ingredientStack.Pop();

            Assert.That(temp, Is.EqualTo(res));

            
        }
        [Test]
        public void IngredientStackHandletAddItemTest()
        {
            Mock<IIngredientStack> mock= new Mock<IIngredientStack>();
            IngredientStackHanler hanler = new IngredientStackHanler(mock.Object);

            mock.Setup(x => x.Push(It.IsAny<FoodIngredient>())).Throws(new StackFullException(null, null));

            hanler.AddItems(new FoodIngredient[] { new FoodIngredient("Tej", 3, Units.liter),
                            new FoodIngredient("Tej", 3, Units.liter)});

            mock.Verify(x => x.Push(It.IsAny<FoodIngredient>()), Times.Once);

        }
        [Test]
        public void GetFoodIngredientTest()
        {
            Mock<IIngredientStack> mock = new Mock<IIngredientStack>();
            IngredientStackHanler hanler = new IngredientStackHanler(mock.Object);

            mock.Setup(x => x.Pop()).Returns(new FoodIngredient("Tej", 3, Units.liter));
            FoodIngredient foodIngredient= hanler.GetFoodIngredient();
            
            mock.Verify(x=>x.Pop(), Times.Once);
            Assert.That(100, Is.EqualTo(foodIngredient.Quantity));
        }


    }
}