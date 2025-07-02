using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    interface ILostProperty :IProperty
    {
        DateTime DateOfLost { get; }
    }
}
