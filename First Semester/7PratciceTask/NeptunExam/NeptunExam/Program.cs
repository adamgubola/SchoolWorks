using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace NeptunExam
{

    class ExamResult
    {
        string neptunCode;


        public string NeptunCode
        {
            get { return neptunCode; }
            set { if (value.Length >5) neptunCode = value; }
        }
        int points;
        public int Points
        {
            get { return points; }
            set { if (value > 0) points = value; }

        }


        public ExamResult(string code, int point)
        {
            NeptunCode = code;
            Points = point;
        }

        public ExamResult(Random random) 
        {
            string temp = "";
            Points = random.Next(1, 101);


            for (int i = 0; i < 6; i++) 
            {
                int randomNum = random.Next(1, 10);
                int A = (int)'A';
                int Z = (int)'Z' + 1;
                char randomChar = (char)random.Next(A, Z);
                int randomPos = random.Next(1, 3);

                if (randomPos == 1)
                {
                    temp += randomChar;
                }
                else if (randomPos == 2) {
                    temp += randomNum;
                }
            }
            NeptunCode = temp;
        }


        public bool Passed()
        {
            if (points > 50)
            {
                return true;
            }
            else { return false; }
        }

        public GradTipe Grade(int[] gradePoint)
        {
            int pointToGrade = -1;

            for (int i = gradePoint.Length - 1; i >= 0; i--)
            {
                if (points > gradePoint[i])
                {
                    pointToGrade = i;
                }
            }

            switch (pointToGrade)
            {
                case 0: return GradTipe.Elégtelen;
                case 1: return GradTipe.Megfelelt;
                case 2: return GradTipe.Közepes;
                case 3: return GradTipe.Jó;
                case 4: return GradTipe.Jeles;

                default: throw new ArgumentException("Érvénytele pontszám");

            }



        }

    }


        enum GradTipe { Jeles, Jó, Közepes, Megfelelt, Elégtelen}

        internal class Program
        {
            static void Main(string[] args)
            {

            Console.WriteLine("Adj meg egy egész számot");

            int userNumber= int.Parse(Console.ReadLine());

            ExamResult[]examResults1= new ExamResult[userNumber];
            Random random = new Random();


            for (int i = 0; i < examResults1.Length; i++) 
            {
                examResults1 [i] = new ExamResult(random);

            }

            int allPoint = 0;
            int result;
            int counter = 0;
            int mucher = 0;
            string mucherExam = "";


            foreach (ExamResult i in examResults1)
            {
                allPoint += i.Points;
                counter++;

                if (mucher < i.Points) { mucher= i.Points; mucherExam = i.NeptunCode; }


                if (i.Passed())
                {
                    Console.WriteLine (i.NeptunCode);
                }
            }
            result = allPoint / counter;

            Console.WriteLine($"Az átlagos pont: {result}");
            Console.WriteLine($"A legmagasabb pontszám: {mucher}, Neptun-kód: {mucherExam}");

        }
    }
    }

