using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGuessTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;

            do
            {
                try
                {
                    Console.WriteLine("Kérlek adj meg egy egész számot 1 és 1000 között");
                    userNumber = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                if (userNumber < 1 && userNumber > 999)
                {
                    Console.WriteLine("A megadott számnak 1 és 1000 között kell lennie");
                }

            } while (userNumber < 1 && userNumber > 999);

            Random random = new Random();
            bool match = true;
            int tries = 0;

            while (match)
            {
                 int computerNumber= random.Next(1, 1000);
                tries++;

                if (computerNumber.Equals(userNumber)) {
                    match = false;
                    Console.WriteLine("A találathot " +  tries + "probálkozás kellett");
                }
            

            }
        }   
        }
    }

