using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPasswordTask8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checking = true;
            bool pressEnter = true;
            bool pressEnterInCheck = true;
            String password = "";
            String passwordCheck = "";

            while (checking)
            {
                try
                {
                    
                        Console.WriteLine("Kérlek add meg a jelszót!");
                    
                    while (pressEnter)
                    {

                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            pressEnter = false;
                            Console.WriteLine();
                            break;
                        }
                        else if (key.Key == ConsoleKey.Backspace && password.Length>0)
                        {
                            password = password.Remove(password.Length-1);
                            Console.Write("\b \b");
                        }
                        else
                        {   
                            password+= key.KeyChar;
                            Console.Write("*");
                        }
                    }

                    Console.WriteLine("Kérleg ellenőrzésként add meg újra a jelszót!");

                    while (pressEnterInCheck)
                    {

                        ConsoleKeyInfo key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            pressEnterInCheck = false;
                            Console.WriteLine(); 
                            break;
                        }
                        else if (key.Key == ConsoleKey.Backspace && passwordCheck.Length>0)
                        {
                            passwordCheck.Remove(passwordCheck.Length - 1);
                            Console.Write("\b \b");
                        }
                        else
                        {
                            passwordCheck+= key.KeyChar;
                            Console.Write("*");
                        }
                    }


                    if (password.Equals(passwordCheck))
                    {
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
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
