using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucsessCalculae=true;
            
            while (sucsessCalculae)
            {
                try
                {

                    Console.WriteLine("Kérlek add meg a magasságodat méterben. Pl.: 1,82");
                    double userHeight = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Kérlek add meg a testsúlyod kiligrammban. Pl.: 78");
                    int userWeight = int.Parse(Console.ReadLine());

                    double userBmi = userWeight / (userHeight * userHeight);

                    Console.WriteLine("A megadott adatok alapján a testtömegindexed " +
                                        userBmi.ToString("#.##"));

                    sucsessCalculae = false;                
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
