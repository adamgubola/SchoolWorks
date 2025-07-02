using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{


    class Book
    {
        string author;
        string title;
        int releaseDate;
        int pageNumber;


        public Book (string author, string title, int releaseDate, int pageNumber)
        {
            this.author = author;
            this.title = title;
            this.releaseDate = releaseDate;
            this.pageNumber = pageNumber;
        }

        public string AllData()
        {
            string allData = $"{author}: {title}, {releaseDate} ({pageNumber} pages)";

            return allData ;
        }



    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Book b =new Book("Stephen King", "Trap", 2000, 600);

            Console.WriteLine(b.AllData());

        }
    }
}
