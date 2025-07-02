using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool taskIsNotFinished = false;

            while (taskIsNotFinished==false)
            {

            Console.WriteLine("Kérlek add meg a születési évszámodat");

            DateTime dateTime = DateTime.Now;

            int currentDate = dateTime.Year;

            
                try
                {
                    int userAge = int.Parse(Console.ReadLine());

                    if (userAge <= 0)
                    {
                        throw new Exception("Az életkornak nullánál nagyobb számnak kell lennie!");
                    }
                    else if (userAge > currentDate)
                    {
                        throw new Exception("Adj meg másik évszámot, még meg sem születtél!");
                    }
                    else
                    {

                        int currentUserAge = currentDate - userAge;
                        Console.WriteLine(currentUserAge + " éves vagy a megadott évszám alapján!");
                        taskIsNotFinished = true;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nem jó formátumot adtál meg, kérlek használj számokat!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
