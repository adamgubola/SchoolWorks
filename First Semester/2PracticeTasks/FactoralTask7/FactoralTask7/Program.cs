using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoralTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Adj meg egy pozitív egész számot");
				int userNumber=int.Parse(Console.ReadLine());
				int factoralNumber = userNumber;

				if(userNumber==0 || userNumber < 0)
				{
					Console.WriteLine("Adj meg pozitív egész számot");
					return;
				}

				for (int i = userNumber-1; i > 0; i--)
				{
					factoralNumber = factoralNumber*i;
				}
				Console.WriteLine("A megadott szám faktorálisa: " + factoralNumber);

			}
			catch (Exception e )
			{

				Console.WriteLine(e.Message);
			}
        }
    }
}
