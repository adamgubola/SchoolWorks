using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice2
{
    public interface IDeliverable
    {
        public int Weight { get; }
        public string Address { get; }

        double CalculatePrice(bool fromLocker);
    }
}
