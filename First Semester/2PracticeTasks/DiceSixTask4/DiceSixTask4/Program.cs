using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DiceSixTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gamers = 0;
            int counter = 0;
            bool rigthNumber = true;

            do
            {
                try
                {
                    Console.WriteLine("Add meg hányan szeretnétek játszani");
                    gamers = int.Parse(Console.ReadLine());
                    rigthNumber = false;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (rigthNumber);

            Random random = new Random();

            int gameerCounter = 1;

            while (counter != 6)
            {
                Console.WriteLine("A dobáshoz nyomj egy entert");

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Enter)
                {
                    counter = random.Next(1, 7);
                    if (gameerCounter == 1)
                    {
                        Console.WriteLine("Az " + gameerCounter + ". számú játékos dobása: " + counter);
                    }
                    else
                    {
                        Console.WriteLine("A " + gameerCounter + ". számú játékos dobása: " + counter);

                    }

                    if (counter == 6)
                    {
                        if (gameerCounter == 1)
                        {
                            Console.WriteLine("A " + gameerCounter + ". számú játékos nyert");

                        }
                        else
                        {
                            Console.WriteLine("A " + gameerCounter + ". számú játékos nyert");

                        }
                    }
                    if (gameerCounter == gamers) gameerCounter = 0;

                    gameerCounter++;

                    
                }
            }
        }
    }
}
    
