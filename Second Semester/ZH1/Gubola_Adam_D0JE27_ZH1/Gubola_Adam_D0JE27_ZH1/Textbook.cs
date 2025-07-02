using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH1
{
    public class Textbook : Book
    {
        public Textbook(string title, string author) : base(title, author)
        {
            this.LoanPeriod = 14;
        }

        public override double CalculateFine(int overdueDays)
        {

            if (overdueDays > 0)
            {
                return 500 + overdueDays * 50;
            }
            else
            {
                return 0;
            }

        }
    }
}
