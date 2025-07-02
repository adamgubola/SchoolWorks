using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HalfHandTask11
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                String userNumberString = "";
                
                ConsoleKeyInfo key;

                Random random = new Random();
                int firstRandom = random.Next(1, 11);
                int secondRandom = random.Next(1, 11);
                int thirdRandom = random.Next(1, 11);
                int credit = 100;
                bool pressSpaceBar=false;

                do
                {
                    Console.WriteLine("A felhasznált kredit megdásához adj meg egy pozitív egész számot 1 és 100 között majd nyomj spacet," +
                              "ha növelni vagy csökkenteni szeretnéd a le és a fel gombokkal teheted meg.");
                    userNumberString = "";
                    do
                    {
                        key = Console.ReadKey(true);

                        if (key.Key != ConsoleKey.Spacebar && key.Key != ConsoleKey.UpArrow && key.Key != ConsoleKey.DownArrow)
                        {
                            userNumberString += key.KeyChar;
                            Console.Write(key.KeyChar);
                            if(key.Key != ConsoleKey.Spacebar) pressSpaceBar = true;

                        }
                    }
                    while (key.Key != ConsoleKey.Spacebar && key.Key != ConsoleKey.UpArrow && key.Key != ConsoleKey.DownArrow);

                   
                    int userNumber = int.Parse(userNumberString);


                    if (userNumber == 0 || userNumber < 0)
                    {
                        Console.WriteLine("Adj meg egy pozitív egész számot");
                        return;
                    }

                    int userCurrentCredit = userNumber;
                    if (key.Key == ConsoleKey.UpArrow || key.Key== ConsoleKey.DownArrow)
                    {
                        do
                        {

                            if (key.Key == ConsoleKey.UpArrow)
                            {
                                userCurrentCredit++;
                                Console.Clear();
                                Console.WriteLine("A tét jelenleg " + userCurrentCredit);

                                if (userCurrentCredit == 100)
                                {
                                    Console.Clear();
                                    Console.WriteLine("A tét jelenleg " + userCurrentCredit +
                                              ", ez a maximális tét");
                                }

                            }
                            else if (key.Key == ConsoleKey.DownArrow)
                            {

                                userCurrentCredit--;
                                Console.Clear();
                                Console.WriteLine("A tét jelenleg " + userCurrentCredit);

                                if (userCurrentCredit == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("A tét jelenleg " + userCurrentCredit +
                                              ", legalab 1 kreditet meg kell adnod");
                                }
                            }
                            key = Console.ReadKey(true);

                        } while (key.Key != ConsoleKey.Spacebar);
                    }


                    if (pressSpaceBar && credit - userCurrentCredit <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A tét nem lehet nagyobb mint a credited. Jelenlegi kredited: " + credit +"\n");
                    }

                    else if (pressSpaceBar && credit - userCurrentCredit >= 0) { 
                        credit = credit - userCurrentCredit;


                        if (firstRandom == secondRandom || secondRandom == thirdRandom || thirdRandom == firstRandom)
                        {
                            credit += userCurrentCredit * 10;
                            Console.Clear();
                            Console.WriteLine("A nyereményed " + userCurrentCredit * 10 + ", a credited pedig " +
                                credit +"\n");
                        }
                        else if (firstRandom == secondRandom && firstRandom == thirdRandom && secondRandom == thirdRandom)
                        {
                            credit += userCurrentCredit * 50;
                            Console.Clear();

                            Console.WriteLine("A nyereményed " + userCurrentCredit * 10 + ", a credited pedig " +
                                credit +"\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sajnos most nem nyertél, a credited "+
                                credit +"\n");
                        }

                    }
                } while (credit > 0 && key.Key!=ConsoleKey.Escape);


            }
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
        }
    }
}
