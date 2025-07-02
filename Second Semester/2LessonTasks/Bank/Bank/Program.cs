using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Owner [] owner = new Owner[] {new Owner("Adam"), new Owner("Béla"), new Owner("Juli")};

            Bank bank1 = new Bank(5);

            Bank bank2 = new Bank(5);

            bank1.AddAccount(owner[0], -20000);
            bank1.AddAccount(owner[1], -10000);
            bank1.AddAccount(owner[2], -20000);
            bank1.AddAccount(owner[0], 20000);
            bank1.AddAccount(owner[1], 10000);
            bank1.BankAcconts[3].Deposit(20000);
            bank1.BankAcconts[4].Deposit(10000);


            bank2.AddAccount(owner[0], -50000);
            bank2.AddAccount(owner[1], -10000);
            bank2.AddAccount(owner[2], -50000);
            bank2.AddAccount(owner[0], 10000);
            bank2.AddAccount(owner[1], 5000);
            bank2.BankAcconts[3].Deposit(10000);
            bank2.BankAcconts[4].Deposit(5000);





            BankCard[] bankCard =
                new BankCard[] {new BankCard(bank1.NewAccount(owner[0], -20000),11111),
                                new BankCard(bank1.NewAccount(owner[0], 20000), 22222),
                                new BankCard(bank1.NewAccount(owner[0], -20000),33333),
                                new BankCard(bank1.NewAccount(owner[0], 20000), 44444),
                                };




            Console.WriteLine(bank1.TotalBalance(owner[0]));
            Console.WriteLine(bank2.TotalBalance(owner[0]));
            Console.WriteLine(bank1.TotalBalance(owner[1]));
            Console.WriteLine(bank2.TotalBalance(owner[1]));

            Console.WriteLine("--------------------");


            Console.WriteLine(bank1.MaximalBalanceAccount(owner[0]));
            Console.WriteLine(bank1.MaximalBalanceAccount(owner[1]));

            Console.WriteLine("--------------------");

            Console.WriteLine(bankCard[0].ToString());
            Console.WriteLine(bankCard[1].ToString());
            Console.WriteLine(bankCard[2].ToString());
            Console.WriteLine(bankCard[3].ToString());












        }
    }
}