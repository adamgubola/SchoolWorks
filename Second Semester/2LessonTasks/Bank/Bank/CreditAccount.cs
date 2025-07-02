using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class CreditAccount : BankAccont
    {

        private int credit;

        public int Credit
        {
            get { return credit; }
            protected set { credit = value; }
        }

        public CreditAccount(Owner owner, int credit) : base(owner)
        {
            this.credit = credit;    
        }

        public override bool WithDraw(int amount)
        {
            if (amount > this.credit) 
            { 
            return false;
            }

            Balance -= amount;
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Hietel egyenlege: {Credit}";
        }
    }
}
