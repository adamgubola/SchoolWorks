using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkNumberTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guessNumber = 0;

            Random random = new Random();
            int maxNumber = 99;
            int minNumber = 1;
            int randomNumber = random.Next(1, 100);
            int userTry = 0;


            try
            {
                Console.WriteLine("A gép gondolt egy számra, adj meg 1 és 100 között egy számot hogy kitaláld");
                do
                {
                    guessNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine(randomNumber);

                    if (guessNumber == 0)
                    {
                        Console.WriteLine("Adj meg egy másik számot, a szám nem lehet 0-a");
                    }
                    else if (guessNumber < randomNumber)
                    {
                        Console.WriteLine("Az általad megadott szám kissebb mint a gondolt szám, próbálkozz újra");
                        userTry++;
                    }
                    else if (guessNumber > randomNumber)
                    {
                        Console.WriteLine("Az általad megadott szám nagyobb mint a gondolt szám, próbálkozz újra");
                        userTry++;

                    }
                    else
                    {
                        userTry++;
                        Console.WriteLine("Eltaláltad a számot, a próbálkozásaid száma: " + userTry);

                    }
                }

                while (guessNumber != randomNumber);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        }
    }

