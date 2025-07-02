using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class CreditCard: PlasticCard, IPaymentInstrument
    {
		private int balance;
              
        public int Balance
		{
			get { return balance; }
			protected set { balance = value; }
		}

        public CreditCard(string owner, int balance) : base(owner)
        {
            this.Balance = balance;
        }


        public virtual bool Pay(int amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;

                return true;


            }
            return false;
        }

        
    }
}
