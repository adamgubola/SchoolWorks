using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh2Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset=new Dataset();
            SubscriptionType subscriptionType;
            bool exit = false;
            DeviceType deviceType;

            do
            {
                Console.WriteLine($"1. Load data file \r\n" +
                    $"2. Get average monthly revenue\r\n" +
                    $"3. List non-paying users\r\n" +
                    $"4. Show distribution of devices\r\n" +
                    $"5. Exit\r\n" +
                    $"" +
                    $"Your choice:");
                int userInput= int.Parse(Console.ReadLine());
               


                if (userInput == 1) {
                    Console.WriteLine("Add meg az bemeneti file nevét!");
                    string userDataInput = Console.ReadLine();
                    dataset = new Dataset(userDataInput);
                    Console.WriteLine("Az adatok beolvasva");
                    string maxAge= dataset.MaximalAgeData();
                    Console.WriteLine(maxAge);

                    //netflix_data.csv
                    Console.ReadLine();
                    Console.Clear();

                }
                else if(userInput == 2) {
                    Console.WriteLine("Add meg az előfizetés típusát: ");
                    subscriptionType =(SubscriptionType) Enum.Parse(typeof(SubscriptionType), Console.ReadLine());
                    string result= dataset.AverageMonthlyRevenue(subscriptionType);
                    Console.WriteLine(result);

                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Add meg a napok számát: ");
                    int userDataInput= int.Parse(Console.ReadLine());
                    User[]nonPayUsers= dataset.CollectNonPayers(userDataInput);
                    for(int i=0; i<nonPayUsers.Length; i++)
                    {
                        Console.WriteLine(nonPayUsers[i].DataAsText());
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Add meg a típust: ");
                    deviceType= (DeviceType) Enum.Parse(typeof(DeviceType), Console.ReadLine());
                    string result= dataset.DistributionOfDeviceType(deviceType);
                    Console.WriteLine(result);
                    Console.ReadLine();
                    Console.Clear();
                }else if(userInput == 5)
                {
                    exit = true;
                }
                else { Console.WriteLine("Nem jó számot adtál meg"); 
                    Console.ReadLine();
                    Console.Clear();
                }


            }while (!exit);
        }


    }
}
