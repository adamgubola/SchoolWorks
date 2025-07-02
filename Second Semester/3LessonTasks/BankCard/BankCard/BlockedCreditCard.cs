using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class BlockedCreditCard : CreditCard, ILostProperty
    {
		private bool lost;
             

        public bool  Lost
		{
			get { return lost; }
			set { lost = value; }
		}

        public BlockedCreditCard(string owner, int balance, bool lost = true) : base(owner, balance)
        {
            this.Lost = lost;
        }

        public DateTime DateOfLost { get; protected set; }

       

        override public bool Pay(int amount) 
        {

            if (this.Lost)
            {
                return false;
            }
            else if (this.Balance >= amount)
            {
                base.Pay(amount);
                
            }
            return false;
        
        
        }
    
    }
}
