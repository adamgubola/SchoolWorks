using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesToHoursTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calculateSuccess = true;

            while (calculateSuccess)
            {
                try
                {
                    Console.WriteLine("Kérlek adj meg másodpercben egy időintervallumot. pl.: 123");

                    int userMinutes = int.Parse(Console.ReadLine());

                    int hours = userMinutes / 60;
                    int minutes = userMinutes - (hours * 60);

                    Console.WriteLine("Az általad megadott idő: " + hours + ":" + minutes.ToString("D2"));

                    calculateSuccess = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
