using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHolder
{
    class Person
    {
        string[] allDatas;

        int[] seqn;
        string[] survay;
        double[] riaGend;
        double[] ridageyr;
        double[] bmxBmi;
        double[] lbdglusi;


        public void fillDatas(string file)
        {
            allDatas = File.ReadAllLines(file);

            seqn = new int[allDatas.Length - 1];
            survay = new string[allDatas.Length - 1];
            riaGend = new double[allDatas.Length - 1];
            ridageyr = new double[allDatas.Length - 1];
            bmxBmi = new double[allDatas.Length - 1];
            lbdglusi = new double[allDatas.Length - 1];

            for (int i = 1, k = 0; i < allDatas.Length; i++, k++)
            {
                string[] dataLines = allDatas[i].Split(',');
                seqn[k] = int.Parse(dataLines[0]);
                survay[k] = dataLines[1];
                riaGend[k] = double.Parse(dataLines[2], CultureInfo.InvariantCulture);
                ridageyr[k] = double.Parse(dataLines[3], CultureInfo.InvariantCulture);
                bmxBmi[k] = double.Parse(dataLines[4], CultureInfo.InvariantCulture);
                lbdglusi[k] = double.Parse(dataLines[5], CultureInfo.InvariantCulture);
            }
        }

        public string avarage()
        {
            int women = 0;
            int men = 0;
            double womenAvarage = 0;
            double manAvarage = 0;

            for (int i = 0; i < riaGend.Length; i++)
            {
                if (riaGend[i] == 1)
                {
                    men++;
                    manAvarage += bmxBmi[i];
                }
                else if (riaGend[i] == 2)
                {
                    women++;
                    womenAvarage += bmxBmi[i];
                }
            }
            womenAvarage = womenAvarage / women;
            manAvarage = manAvarage / men;

            string result = "Nők: " + womenAvarage + " Férfiak: " + manAvarage;

            return result ;
        }


        public string overNormal()
        {
            int overNormal = 0;
            int underNormal = 0;
            int all = lbdglusi.Length;

            for (int i = 0; i < lbdglusi.Length; i++)
            {
                if (lbdglusi[i] > 5.6)
                {
                    overNormal++;
                }
                else { underNormal++; }
            }

            double result = ((double)overNormal / all) * 100;

            string overNormalResult="Átlag: " + result.ToString("F2");

            return overNormalResult ;
        }

        public string maxSugarAndavarageAgeOver30()
        {
            double maxBMI = 0;
            int numOfHigher = 0;
            int numsOver30 = 0;
            double avarageAge = 0.0;

            for (int i = 0; i < bmxBmi.Length; i++)
            {
                if (bmxBmi[i] > maxBMI)
                {
                    maxBMI = bmxBmi[i];
                    numOfHigher = i;

                }
                else if (bmxBmi[i] > 30.0)
                {
                    numsOver30++;
                    avarageAge += ridageyr[i];

                }
            }
            avarageAge = avarageAge / numsOver30;


            string sugarAndOver30= "A max cukorszint: " + lbdglusi[numOfHigher]+ " " + "Az átlagos életkor 30 BMI felett: " + avarageAge;

            return sugarAndOver30 ;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\Users\user\source\repos\MyFirstDatas\NHANES_1999-2018.csv";

            Person person= new Person();

            person.fillDatas(file);
            Console.WriteLine(person.avarage());
            Console.WriteLine(person.overNormal());
            Console.WriteLine(person.maxSugarAndavarageAgeOver30());


        }
    }
}
