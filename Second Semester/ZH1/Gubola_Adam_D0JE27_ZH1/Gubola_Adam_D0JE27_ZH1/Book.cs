using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH1
{
    public abstract class Book : IBookable
    {
        
        public string Title { get; private set; }

        public string Author { get; private set; }

        public int LoanPeriod { get; set; }

        public ELanguage ELanguage { get; private set; }

        protected Book(string title, string author, ELanguage eLanguage)
        {
            Title = title;
            Author = author;
            ELanguage = eLanguage;
        }

        protected Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public abstract double CalculateFine(int overdueDays);

        public override string? ToString()
        {
            return $"Könyv: {this.Title} / Szerző: {this.Author} / Nyelv: {this.ELanguage} / kölcsönzési időszak: {this.LoanPeriod} nap";
        }
    }
}
