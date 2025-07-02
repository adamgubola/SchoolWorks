using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankCard : BankService
    {

        private int cardNumber;
        private BankAccont bankAccont;

        public BankAccont BankAccont
        {
            get { return bankAccont; }
            private set { bankAccont = value; }
        }


        public int CardNumber
        {
            get { return cardNumber; }
            private set { cardNumber = value; }
        }

        public BankCard(Owner owner, BankAccont bankAccont, int cardNumber) : base(owner)
        {
            this.bankAccont = bankAccont;
            this.cardNumber = cardNumber;
        }
        public BankCard(BankAccont bankAccont,int cardNumber) : base(bankAccont.Owner)
        {
            this.bankAccont = bankAccont;
            this.cardNumber = cardNumber;
        }

        public bool Purchase(int amount)
        {
            return BankAccont.WithDraw(amount);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Bankkártya száma: {this.CardNumber}";
        }
    }
}
