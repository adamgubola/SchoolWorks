using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        private BankAccont[] bankAcconts;

        public BankAccont[] BankAcconts {  get { return bankAcconts; } }

        int index = 0;

        public Bank(int pieces)
        {
            this.bankAcconts = new BankAccont[pieces];
        }
        public BankAccont NewAccount(Owner owner, int creditLimit)

        {   
         

            if (creditLimit <= 0)
                    {
                    return new CreditAccount(owner, creditLimit);
                    }
                    else
                    {
                    return new SavingsAccount(owner);
                    }
            
           }

        public void AddAccount(Owner owner, int creditLimit)
        {
            if (index >= bankAcconts.Length)
            {
                Console.WriteLine("Nincs több hely a tömbben!");
                return;
            }

            BankAccont newAccount = NewAccount(owner, creditLimit);

            bankAcconts[index] = newAccount;
            index++;
        }



        public int TotalBalance( Owner owner)
        {
            int sum = 0;
            for (int i = 0; i < bankAcconts.Length; i++)
            {
                if (bankAcconts[i].Owner.Name == owner.Name)
                {

                    sum += bankAcconts[i].Balance;

                }
                
            }
            return sum;
        }
        public BankAccont MaximalBalanceAccount(Owner owner)
        {
            int max = int.MinValue;
            int index = -1;
            BankAccont tempAccount = null;

            for (int i = 0; i < bankAcconts.Length; i++) 
            {
                if (bankAcconts[i].Owner == owner) 
                {
                    if (bankAcconts[i].Balance > max)
                        max=bankAcconts[i].Balance;
                        tempAccount = bankAcconts[i];
                        index++;
                        
                }
            }
            if(index == -1) { return null; }

            return tempAccount;

        }


        public int TotalCreditLimit()
        {
            int AllCreditLimit = int.MinValue;

            for (int i = 0;i < bankAcconts.Length; i++)
            {
                if(bankAcconts[i] is CreditAccount credit)
                {
                    AllCreditLimit += credit.Credit;
                }
            }
            return AllCreditLimit;
        }
    }
}
