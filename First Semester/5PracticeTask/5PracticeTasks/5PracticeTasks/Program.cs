using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _5PracticeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Directory.CreateDirectory(@"C:\Users\user\source\repos\MyFirstDatas");


            //string text = "Red#Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\nBlue#Suspendisse eros erat, ornare quis magna vitae, rutrum interdum turpis.\r\nGreen#Morbi pellentesque ut sem sed dapibus.";

            //File.WriteAllText(@"C:\Users\user\source\repos\MyFirstDatas\FirstTask.txt", text, System.Text.Encoding.ASCII);


            //string readText = File.ReadAllText(@"C:\Users\user\source\repos\MyFirstDatas\FirstTask.txt");
            //string[] readArray = File.ReadAllLines(@"C:\Users\user\source\repos\MyFirstDatas\FirstTask.txt");
            //string[] colours=new string[readArray.Length];

            //for (int i = 0; i < readArray.Length; i++)
            //{
            //    colours[i] = readArray[i].Substring(0, readArray[i].IndexOf('#'));

            //    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colours[i], true);
            //    Console.WriteLine(readArray[i]);
            //    Console.ResetColor();

            //}







            //------------------------------------------------------------------------------------------------------------------------



            Directory.CreateDirectory(@"C:\Users\user\source\repos\MyFirstDatas\Lotto");
            string filePath = @"C:\Users\user\source\repos\MyFirstDatas\Lotto\lotto.txt";

            StreamWriter streamWriter = new StreamWriter(filePath, true);

            string lottoNumbers = "";
            Random random = new Random();
            bool contains = false;
            bool nextPick = true;
            int counter = 0;


            do
            {

                lottoNumbers = "";



                for (int i = 0; i < 5; i++)
                {
                    contains = false;

                    while (contains == false)
                    {
                        int randomNumber = random.Next(1, 91);

                        string temporarRandom = "" + randomNumber;


                        if (i == 0)
                        {
                            lottoNumbers += randomNumber + " ";
                            contains = true;
                        }


                        else if (i > 0 && !lottoNumbers.Contains(temporarRandom))
                        {
                            lottoNumbers += randomNumber + " ";
                            contains = true;

                        }
                    }
                }

                DateTime today = DateTime.Now;

                DateTime futureDate = today.AddDays(counter * 7);

                string formattedDate = futureDate.ToString("yyyy-MM-dd");


                string date = "On " + formattedDate + " numsbers where: ";

                lottoNumbers = date + lottoNumbers;

                streamWriter.WriteLine(lottoNumbers);

                Console.WriteLine(lottoNumbers);

                Console.WriteLine("Another week? [y/n]");

                string next = Console.ReadLine().ToLower();


                if (!next.Equals("y")) { nextPick = false; }

                counter++;

            }

            while (nextPick);

            streamWriter.Close();
        }
    



            //------------------------------------------------------------------------------------------------------------------------



            //            string[] allDatas = File.ReadAllLines(@"C:\Users\user\source\repos\MyFirstDatas\NHANES_1999-2018.csv");

            //            int[] seqn = new int[allDatas.Length-1];
            //            string[] survay = new string[allDatas.Length-1];
            //            double[] riaGend=new double[allDatas.Length - 1];
            //            double[] ridageyr = new double[allDatas.Length - 1];
            //            double[] bmxBmi = new double[allDatas.Length - 1];
            //            double[] lbdglusi = new double[allDatas.Length - 1];

            //            for ( int i = 1, k = 0 ; i < allDatas.Length; i++, k++) 
            //            { 
            //            string[] dataLines = allDatas[i].Split(',');
            //                seqn[k]= int.Parse(dataLines[0]);
            //                survay[k] = dataLines[1];
            //                riaGend[k]= double.Parse(dataLines[2], CultureInfo.InvariantCulture);
            //                ridageyr[k]= double.Parse(dataLines[3], CultureInfo.InvariantCulture);
            //                bmxBmi[k]= double.Parse(dataLines[4], CultureInfo.InvariantCulture);
            //                lbdglusi[k]= double.Parse(dataLines[5], CultureInfo.InvariantCulture);
            //            }

            //            int women = 0;
            //            int men = 0;
            //            double womenAvarage = 0;
            //            double manAvarage = 0;

            //            for (int i = 0; i < riaGend.Length; i++) 
            //            {
            //                if (riaGend[i] == 1)
            //                {
            //                    men++;
            //                    manAvarage += bmxBmi[i];
            //                }
            //                else if (riaGend[i] == 2) 
            //                {
            //                    women++;
            //                    womenAvarage += bmxBmi[i];
            //                }
            //            }
            //            womenAvarage = womenAvarage / women;
            //            manAvarage = manAvarage / men;

            //            Console.WriteLine("Nők: " + womenAvarage + " Férfiak: " + manAvarage);

            //            int overNormal = 0;
            //            int underNormal = 0;
            //            int all= lbdglusi.Length;

            //            for (int i = 0; i < lbdglusi.Length; i++)
            //            {
            //                if (lbdglusi[i] > 5.6)
            //                {
            //                    overNormal++;
            //                }
            //                else { underNormal++; }
            //            }

            //            double result = ((double)overNormal / all) * 100;
            //            Console.WriteLine("Átlag: "+ result.ToString("F2"));

            //            double maxBMI = 0;
            //            int numOfHigher = 0;
            //            int numsOver30 = 0;
            //            double avarageAge = 0.0;

            //            for (int i = 0; i < bmxBmi.Length; i++) 
            //            {
            //                if (bmxBmi[i] > maxBMI) 
            //                {
            //                    maxBMI = bmxBmi[i];
            //                    numOfHigher = i;

            //                }
            //                else if (bmxBmi[i] > 30.0) 
            //                { 
            //                    numsOver30++;
            //                    avarageAge += ridageyr[i];

            //                }
            //            }
            //            avarageAge = avarageAge / numsOver30;


            //            Console.WriteLine("A max cukorszint: " + lbdglusi[numOfHigher] );
            //            Console.WriteLine("Az átlagos életkor 30 BMI felett: " + avarageAge );




            //            }
            }
        }
