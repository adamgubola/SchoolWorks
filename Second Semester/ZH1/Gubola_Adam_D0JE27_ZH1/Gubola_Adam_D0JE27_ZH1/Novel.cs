using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH1
{
    public class Novel : Book
    {
        public string Description { get; private set; }

        public Novel(string title, string author, ELanguage eLanguage) : base(title, author, eLanguage)
        {
        }

        public Novel(string title, string author, string description, int loanPeriod) : base(title, author)
        {
            Description = description;
            LoanPeriod = loanPeriod;

        }

       

        public override double CalculateFine(int overdueDays)
        {
            if (this.LoanPeriod > 30)
            {
                throw new LateReturnException();
            }
            else
            {
                return overdueDays * 200;
            }
        }
    }
}
