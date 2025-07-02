using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh_First
{
    public interface IDeliverable
    {
         int Weight { get; }

         string Address { get; }

         double CalculatePrice(bool fromLocker);
    }
}
