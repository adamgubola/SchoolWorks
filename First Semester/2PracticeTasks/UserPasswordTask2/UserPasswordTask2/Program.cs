using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPasswordTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg a jelszavad");
            String password = Console.ReadLine();
            Console.Clear();
            int counter = 0;

            do
            {
                Console.WriteLine("Kérlek add meg a jelszavadat újra");
                String passwordAgain = Console.ReadLine();
                Console.Clear();
                if (password.Equals(passwordAgain)){
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("A jelszavak egyeznek");
                    Console.BackgroundColor = ConsoleColor.Black;
                    
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("A jelszavak nem egyeznek");
                    Console.BackgroundColor = ConsoleColor.Black;
                    counter++;


                }
            }
            while (counter != 3);

            Console.WriteLine("Háromszor hibás jelszót adtál meg");
        }
    }
}
