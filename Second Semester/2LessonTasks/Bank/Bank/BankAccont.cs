using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    abstract class BankAccont :BankService
    {
		private int balance;
		

		public BankAccont(Owner owner) : base(owner)
        {
        }

        public int Balance
		{
			get { return balance; }
			protected set { balance = value; }
		}

		public void Deposit(int amount)
		{
			this.balance += amount;
		}

		public abstract bool WithDraw(int amount);

		public BankCard NewCard(int cardnumber) 
		{
			return new BankCard(this, cardnumber);

		}

        public override string ToString()
        {
            return $"Tulajdonos neve: {this.Owner.Name}, teljes egyenlege: {this.Balance}";
        }
    }


}
