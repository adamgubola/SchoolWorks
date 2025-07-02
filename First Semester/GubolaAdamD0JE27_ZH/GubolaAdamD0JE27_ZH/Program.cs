using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GubolaAdamD0JE27_ZH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gubola Ádám D0JE27//

            string[] allData = File.ReadAllLines(@"C:\Users\user\source\repos\GubolaAdamD0JE27_ZH\GubolaAdamD0JE27_ZH\crypto.csv");

            DateTime[] date = new DateTime[allData.Length - 1];
            string[] name = new string[allData.Length - 1];
            double[] openExchange = new double[allData.Length - 1];
            double[] closeExchange = new double[allData.Length - 1];

            for (int i = 1, j = 0; i < allData.Length; i++, j++)
            {
                string[] oneLine = allData[i].Split(';');
                date[j] = DateTime.Parse(oneLine[0]);
                name[j] = oneLine[1];
                openExchange[j] = double.Parse(oneLine[2], CultureInfo.InvariantCulture);
                closeExchange[j] = double.Parse(oneLine[3], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Adj meg egy évet");

            int userYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Adj meg egy hónapot");

            int userMonth = int.Parse(Console.ReadLine());


            Console.WriteLine(userYear + " " + userMonth+ date[1].Year + date[1].Month);


            double difference = 0.0;


            for (int i = 0; i < date.Length; i++)
            {

                if (name[i].Equals("Bitcoin"))
                {
                    if (date[i].Year == userYear && date[i].Month == userMonth)
                    {

                        double open2 = openExchange[i];
                        double close2 = closeExchange[i];

                        difference = open2 - close2;

                        Console.WriteLine(difference);
                    }
                }

                else if (name[i].Equals("Ethereum"))
                {
                    if (date[i].Year == userYear && date[i].Month == userMonth)
                    {

                        double open2 = openExchange[i];
                        double close2 = closeExchange[i];

                        difference = open2 - close2;

                        Console.WriteLine(difference);
                    }
                }

                else if (name[i].Equals("Tether"))
                {

                    if (date[i].Year == userYear && date[i].Month == userMonth)
                    {

                        double open2 = openExchange[i];
                        double close2 = closeExchange[i];

                        difference = open2 - close2;

                        Console.WriteLine(difference);
                    }
                }

            }

            Console.WriteLine("Adj meg egy nevet");
            string userName = Console.ReadLine();

            double open = 0.0;
            double close = 0.0;
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals(userName))
                {
                    open += openExchange[i];
                    close += closeExchange[i];
                    counter1++;
                    counter2++;
                }


            }

            double avarageOpen= open / counter1;
            double avarageClose = close / counter1;
            Console.WriteLine("Átlagos nyitó " + avarageOpen + "átlagos záró " + avarageClose);

            double[]Bitc= new double[openExchange.Length];
            double[]Et= new double[openExchange.Length];
            double[] Th = new double[openExchange.Length];




            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals("Bitcoin"))
                {
                    Bitc[i]= (openExchange[i] - closeExchange[i]) / openExchange[i];
                }
                else if (name[i].Equals("Ethereum"))
                {
                    Et[i] = (openExchange[i] - closeExchange[i]) / openExchange[i];
                }
                else if (name[i].Equals("Tether"))
                {
                    Th[i]= (openExchange[i] - closeExchange[i]) / openExchange[i];
                }


            }

            double counter4 = 0.0;

            for (int i = 0; i < Bitc.Length; i++) { 
            
                if (Bitc[i] > counter4)
                {
                    counter4 = Bitc[i];
                }


            }
            Console.WriteLine(counter4);

            double counter5 = 0.0;

            for (int i = 0; i < Et.Length; i++)
            {

                if (Et[i] > counter5)
                {
                    counter5 = Et[i];
                }
            }
            Console.WriteLine(counter5);

            double counter6 = 0.0;

            for (int i = 0; i < Th.Length; i++)
            {

                if (Th[i] > counter6)
                {
                    counter6 = Th[i];
                }


            }
            Console.WriteLine(counter6);

        }
    }
}