using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class Credit :IPaymentInstrument
    {
		private int amountOfCredit;

		public int AmountOfCredit
		{
			get { return amountOfCredit; }
			protected set { amountOfCredit = value; }
		}

        public Credit(int amountOfCredit)
        {
            AmountOfCredit = amountOfCredit;
        }

        public bool Pay(int amount)
        {

            if (this.AmountOfCredit >= amount)
            {
                this.AmountOfCredit -= amount;

                return true;


            }
            return false;
        }
    }
}
