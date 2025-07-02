using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZhPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] genre=File.ReadAllText(@"C:\Users\user\source\repos\ZhPractice\ZhPractice\genre.txt").Split(',');
            string[] allData = File.ReadAllLines(@"C:\Users\user\source\repos\ZhPractice\ZhPractice\games_dataset.csv");


            string[] title=new string[allData.Length-1];
            int[]genreId=new int[allData.Length-1];

            string[] genreIdWithWord= new string[allData.Length-1];
            string[]publisher=new string[allData.Length-1];
            DateTime[]releaseDate=new DateTime[allData.Length-1];
            DateTime[]originalRelese=new DateTime[allData.Length-1];

            for (int i = 1, j=0; i < allData.Length; i++, j++) 
            {
                string[] oneLine = allData[i].Split(';');
                title[j] = oneLine[0];
                genreId[j] = int.Parse(oneLine[1]);
                genreIdWithWord[j] = genre[int.Parse(oneLine[1])-1];
                publisher[j]=oneLine[2];
                releaseDate[j]= DateTime.Parse(oneLine[3]);
                originalRelese[j] = DateTime.Parse(oneLine[4]);

            }

            Console.WriteLine("Aja meg a kiadó nevét:");
            string input1=Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < publisher.Length; i++) 
            {
                if (input1.ToLower().Equals(publisher[i].ToLower())) 
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);


            for (int i = 0; i < originalRelese.Length; i++)
            {
                if (releaseDate[i] == originalRelese[i])
                {
                    Console.WriteLine(title[i]+ " " + genreIdWithWord[i] + " " + originalRelese[i].ToString("yyyy:MM:dd"));

                }
            }
            int[] counter2 = new int[genre.Length];

            for (int i = 0; i < genreId.Length; i++) 
            {

                counter2[genreId[i]-1]++;

            }
            Console.WriteLine("\n");

            for (int i = 0; i < counter2.Length; i++)
            {
                Console.WriteLine(genre[i] + " " + counter2[i]);

            }


        }
    }
}
