using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SavingsAccount :BankAccont
    {
		private int interest;
		private static int regularInterest = 5;

        public SavingsAccount(Owner owner) : base(owner)
        {
            this.interest = regularInterest;
        }

        public int Interest
		{
			get { return interest; }
			set { interest = value; }
		}

       

        public override bool WithDraw(int amount)
        {
            if(amount<= Balance) 
            { 
                Balance-=amount; 
                return true;            
            }
            return false;
        }
        public void AddInterest()
        {
            this.interest += Balance * this.interest;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Kamat mértéke: {this.Interest}";
        }
    }
}
