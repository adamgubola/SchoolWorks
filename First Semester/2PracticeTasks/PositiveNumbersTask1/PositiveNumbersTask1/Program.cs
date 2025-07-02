using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNumbersTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userNumber;
            int i;

            try
            {
                do
                {
                    Console.WriteLine("Kérlek adj meg egy pozitív egész számot!");
                    userNumber = int.Parse(Console.ReadLine());

                    if (userNumber < 0)
                    {
                        throw new Exception("A számnak pozitív számnak kell lennie");
                    }

                    for (i = 0; i < userNumber; i++)
                    {
                        Console.WriteLine(i);
                    }



                }
                while ( i == userNumber-1);
              

            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }

        }
    }
}
