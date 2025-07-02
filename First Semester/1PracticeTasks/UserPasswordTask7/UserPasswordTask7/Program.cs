using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPasswordTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checking = true;
            while (checking) {
                try
                {
                    Console.WriteLine("Kérlek add meg a jelszót!");
                    String password = Console.ReadLine();

                    Console.WriteLine("Kérleg ellenőrzésként add meg újra a jelszót!");
                    String passwordCheck = Console.ReadLine();


                    if (password.Equals(passwordCheck)){
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("A jelszavak megegyeznek!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A jelszavak nem egyeznek");
                    }
                    checking = false;
                }
                catch ( Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
