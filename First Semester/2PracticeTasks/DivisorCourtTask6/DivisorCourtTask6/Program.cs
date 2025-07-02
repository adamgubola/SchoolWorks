using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorCourtTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int userNumber = 0;
			int counter = 0;

			try
			{
				Console.WriteLine("Adj meg egy pozitív egész számot");
				userNumber = int.Parse(Console.ReadLine());

				if (userNumber % 2 == 0)
				{
					Console.WriteLine("A megadott szám páros szám");
				}
				else {
                    Console.WriteLine("A megadott szám páratlan szám");
                }


				if (userNumber == 0 || userNumber < 0)
				{
					throw new Exception("A szám nem pozitív, egész szám");
				}
				for (int i = 2; i < userNumber; i++)
				{
					if (userNumber % i == 0)
					{
						counter++;
					}
				}
				
				Console.WriteLine("A megadott szám osztótnak száma: " + counter);
				if (counter != 0 || userNumber==2)
				{
                    Console.WriteLine("A megadott szám nem prím szám");
                }
				else {
                    Console.WriteLine("A megadott szám prím szám");
                }




			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
        }
    }
}
