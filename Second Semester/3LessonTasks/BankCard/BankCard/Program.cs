using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPaymentInstrument[] instruments = new IPaymentInstrument[] {

                 new CreditCard("Adam",10000),
                   new CreditCard("Bela", 20000),
                   new BlockedCreditCard("Jani", 30000),
                   new Credit(40000)
              };

            Console.WriteLine(Payment(instruments, 20000));
            Console.WriteLine("______________________");
            Console.WriteLine(Payment(instruments, 5000, "Adam"));


        }


        public static bool Payment(IPaymentInstrument[] instruments, int amount)

        {
            bool temp = false;

            for (int i = 0; i < instruments.Length; i++) 
            
            {
                Console.WriteLine(instruments[i].Pay(amount).ToString());
                if (instruments[i].Pay(amount))
                {
                    temp= true;
                }
            
            }
            return temp;

        }
        public static bool Payment(IPaymentInstrument[] instruments, int amount, string name)

        {
            bool temp = false;

            for (int i = 0; i < instruments.Length; i++)
            {
                if (instruments[i] is CreditCard c)
                {

                    if (c.Pay(amount) && c.Owner.Equals(name))
                    {
                        Console.WriteLine(c.Pay(amount).ToString());
                        temp = true;
                    }
                }

                else if (instruments[i] is BlockedCreditCard bcard)
                {

                    if (bcard.Pay(amount) && bcard.Owner.Equals(name))
                    {
                        Console.WriteLine(bcard.Pay(amount).ToString());
                        temp = true;
                    }
                }

                else if (instruments[i] is Credit credit)
                {

                    if (credit.Pay(amount))
                    {
                        Console.WriteLine(credit.Pay(amount).ToString());
                        temp = true;
                    }
                }
                }
            return temp;

        }

    }

}
