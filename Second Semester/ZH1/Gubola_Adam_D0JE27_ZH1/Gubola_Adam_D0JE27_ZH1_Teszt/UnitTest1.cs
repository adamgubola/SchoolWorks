using Gubola_Adam_D0JE27_ZH1;

namespace Gubola_Adam_D0JE27_ZH1_Teszt
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase (31)]
        public void NovelCalculateFineException(int loanPeriod)
        {
            Novel novel = new Novel("Valami", "Valaki", "Novel", loanPeriod);

            Assert.Throws<LateReturnException>(() => novel.CalculateFine(10));
            
        }

        [TestCase(10, 2000)]
        [TestCase(20, 4000)]

        public void NovelCalculateFinePrice(int price, int except)
        {
            Novel novel = new Novel("Valami", "Valaki", "Novel", 25);

            Assert.That(novel.CalculateFine(price), Is.EqualTo(except));
        }
            

        [TestCase(0, 0)]
        [TestCase(10, 1000)]

        public void TextBookCalculateFinePrice(int price, int except)
        {
            Textbook text = new Textbook("Valami", "Valaki");

            Assert.That(text.CalculateFine(price), Is.EqualTo(except));
        }

        [Test]
        public void LibraryAddException()
        {
            Library library = new Library(2);

            library.AddBook(new Novel("Valami", "Valaki", "Novel", 25));
            library.AddBook(new Novel("Valami", "Valaki", "Novel", 25));


            Assert.Throws<LibraryFullException>(() => library.AddBook(new Novel("Valami", "Valaki", "Novel", 25)));
            

        }

        [Test]
        public void LibraryOverdue()
        {
            Library library = new Library(5);

            library.AddBook(new Novel("Valami", "Valaki", "Novel", 30));
            library.AddBook(new Novel("Valami", "Valaki", "Novel", 24));
            library.AddBook(new Novel("Valami", "Valaki", "Novel", 29));
            library.AddBook(new Novel("Valami", "Valaki", "Novel", 25));
            library.AddBook(new Textbook("Valami", "Valaki"));

            IBookable[] bookable = library.OverdueBooks(25);

            Assert.That(bookable.Length, Is.EqualTo(2));
       

        }



    }
}