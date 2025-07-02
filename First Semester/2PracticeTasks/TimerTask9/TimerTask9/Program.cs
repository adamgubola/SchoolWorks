using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerTask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Adj meg egy pozitív egész számot");
				int userNumber	= int.Parse(Console.ReadLine());
				

				if (userNumber == 0 || userNumber < 0) 
				{
				Console.WriteLine("Adj meg egy pozitív egész számot");
				return;
				}


				for (int i = userNumber; i >0; i--)
				{
					Console.Clear();
					int minutes = i / 60;
					int seconds = i % 60;
					Console.WriteLine(minutes.ToString("D2") + ":" + seconds.ToString("D2"));
					
					System.Threading.Thread.Sleep(1000);
					
				}
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
				Console.Beep();
                Console.WriteLine("00:00");

            }
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
        }
    }
}
