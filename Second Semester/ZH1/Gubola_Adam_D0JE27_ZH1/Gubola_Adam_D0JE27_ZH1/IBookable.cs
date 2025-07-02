using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gubola_Adam_D0JE27_ZH1
{
    public interface IBookable
    {
        public string Title { get; }
        public string Author { get; }
        
        public int LoanPeriod { get; }

        public double CalculateFine(int overdueDays);
    }
}
