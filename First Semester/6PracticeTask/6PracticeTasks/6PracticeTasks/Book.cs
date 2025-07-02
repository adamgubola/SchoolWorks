using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PracticeTasks
{
    public class Book
    {
        string author;
        string title;
        int releaseDate;
        int pageNumber;


        public Book(string author, string title, int releaseDate, int pageNumber)
        {
            this.author = author;
            this.title = title;
            this.releaseDate = releaseDate;
            this.pageNumber = pageNumber;
        }

        public string AllData()
        {
            string allData = $"{author}: {title}, {releaseDate} ({pageNumber} pages)";

            return allData;
        }
    }
}
