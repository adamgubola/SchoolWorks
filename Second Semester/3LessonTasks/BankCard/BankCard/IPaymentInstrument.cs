using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    interface IPaymentInstrument
    {
        bool Pay(int amount);

    }
}
