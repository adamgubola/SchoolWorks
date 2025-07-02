using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4PracticeTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string text = "asdhalshdfl7687dsfvkshr";
            //int letters = 0;
            //int digits=0;
            //int other = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (char.IsLetter(text[i]))
            //    {
            //        letters += 1;
            //    }
            //    else if (char.IsDigit(text[i])) { digits += 1; }

            //    else if ("öüóúőoiueaéáűí".Equals(text[i])){ other += 1; }

            //}
            //Console.WriteLine(letters + " " + digits + " " + other);

            //string poem = "Géza kék az ég";
            //string reverse = "";
            //poem=poem.ToLower().Replace(" ","");


            //char[] poemChars = poem.ToCharArray();

            //for (int i=poemChars.Length-1; i>=0; i--) {
            //     reverse += poemChars[i];
            //        }

            //Console.WriteLine(reverse);


            //if (reverse.Equals(poem)) {
            //    Console.WriteLine("A szöveg az" );
            //}
            //else
            //{
            //    Console.WriteLine("Nem az");
            //}


//------------------------------------------------------------------------------------------------------------------------


            //Random rnd = new Random();
            //Random rnd2 = new Random();

            //string random = "";
            //for (int i = 0; i < 6; i++)
            //{
            //    int numOfChars = rnd.Next('a', 'z' + 1);
            //    int numsOfNums = rnd2.Next(1, 10);

            //    if (i < 4) { random += (char)numOfChars; }
            //    else { random += numsOfNums; }

            //}
            //    Console.WriteLine(random);
            //    string plate = random;
            //    plate = plate.ToUpper().Replace(" ", "");
            //    plate = plate.Insert(2, " ");
            //    plate = plate.Insert(5, "-");

            //    Console.WriteLine(plate);


 //------------------------------------------------------------------------------------------------------------------------



            //string email = "adamgubola@gmail.com";
            //int emailIndex = 0; ;
            //bool isletter = false;
            //bool isDot = false;
            //int dotIndex = 0;

            //if (email.Contains("@"))
            //{
            //    emailIndex = email.IndexOf("@");
            //    string check = email.Substring(0, emailIndex);

            //    for (int i = 0; i < check.Length; i++)
            //    {
            //        if (char.IsLetter(check[i])) { isletter = true; }

            //    }
            //    if (check.Contains("."))
            //    {
            //        isDot = true;
            //        dotIndex = check.IndexOf(".");
            //    }

            //    if (isDot)
            //    {
            //        if (char.IsLetter(check[dotIndex - 1]) && char.IsLetter(check[dotIndex + 1]))
            //        {
            //        }
            //        else
            //        {
            //            Console.WriteLine("A szöveg első felében a . előtt és után betűnek kell lennie");
            //        }
            //    }
            //    if (isletter)
            //            {
            //                string checkSecond = email.Substring(emailIndex + 1);
            //                if (checkSecond.Contains("."))
            //                {
            //                    int lastDotIndex = checkSecond.IndexOf(".");

            //                    if (char.IsLetter(checkSecond[lastDotIndex + 1]) && char.IsLetter(checkSecond[lastDotIndex + 2]))
            //                    {
            //                        Console.WriteLine("Az email cím helyes");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Az utolsó . karakter után legalább 2 betűnek kell következnie");
            //                    }

            //                }
            //                else
            //                {
            //                    Console.WriteLine("A szöveg második felében nincsen . karakter");
            //                }

            //            }
            //}
            //else
            //{
            //    Console.WriteLine("Nem tartalmaz @ jelet");
            //}




 //------------------------------------------------------------------------------------------------------------------------


            string myCode = "D0JE27";
            string randomNeptun = "";

            Random random = new Random();
            int counter = 0;

            Console.WriteLine("Megy a számolás");

            do
            {
                randomNeptun = "";
                for (int i = 0; i < 6; i++)
                {

                    int randChar = random.Next('A', 'Z' + 1);
                    int randomForRandom = random.Next(1, 3);
                    int randNums = random.Next(0, 10);


                    if (i == 0)
                    {
                        randomNeptun += (char)randChar;
                    }
                    else if (i > 0 && randomForRandom == 1)
                    {
                        randomNeptun += (char)randChar;
                    }
                    else if (i > 0 && randomForRandom == 2)
                    {
                        randomNeptun += randNums;
                    }
                }


                counter++;
                if (myCode.Equals(randomNeptun))
                {
                    Console.WriteLine("Az egyezés " + counter.ToString() + " próbálkozás után volt");

                }

            } while (!myCode.Equals(randomNeptun));


            if (myCode.Equals(randomNeptun))
            {
                Console.WriteLine("Az egyezés " + counter.ToString() + " próbálkozás után volt");

            }

//------------------------------------------------------------------------------------------------------------------------



            //Random random = new Random();
            //string text = "Well, a Big Mac's a Big Mac, but they call it le Big-Mac.";
            //text = text.ToLower();

            //for (int i = 0; i < text.Length; i++)
            //{

            //    int randomtoUp = random.Next(1, 3);

            //    if (randomtoUp == 1)
            //    {
            //        char textChar = char.ToUpper(text[i]);
            //        text= text.Replace(text[i], textChar);

            //    }

            //}
            //Console.WriteLine(text);



            //string input = "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf";

            //string[] inputRow= input.Split('\n');

            //string[] inputCol= inputRow[0].Split(';');

            //int inputRows = inputRow.Length;
            //int inputCols = inputCol.Length;

            //string [,] output = new string[inputRows,inputCols];

            //for (int i = 0; i < inputRows; i++)
            //{
            //    string [] currentInputCol = inputRow[i].Split(';');

            //    for (int j = 0; j < inputCols; j++)
            //    {
            //        output[i,j]= currentInputCol[j];

            //    }
            //}

            //for (int i = 0; i < inputRows; i++)
            //{
            //    string[] currentInputCol = inputRow[i].Split(';');

            //    for (int j = 0; j < inputCols; j++)
            //    {
            //        output[i, j] = currentInputCol[j];

            //        Console.Write(output[i, j] + "\t");

            //    }
            //    Console.Write("\n");

            //}



        }

    }
}
        
    

