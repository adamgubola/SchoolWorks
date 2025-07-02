using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GubolaAdam_D0JE27_ZH2
{
    public class Koktel
    {
        string koktailName;

        public string KoktailName { get { return this.koktailName; } }

        Osszetevok[] osszetevok;

        public Osszetevok[] Hozzaad(string datas)
        {
            string[] inputDatas = File.ReadAllLines(datas);
            this.osszetevok = new Osszetevok[inputDatas.Length];

            for (int i = 0; i < osszetevok.Length; i++)
            {
                this.osszetevok[i] = new Osszetevok(inputDatas[i]);
            }

            return this.osszetevok;
        }

        public Koktel(string inputKoktailName, string fileName) 
        { 
            this.koktailName = inputKoktailName;
            this.osszetevok = Hozzaad(fileName);
        }

        public string OsszAlkoholtartalom() 
        {
            int allAlcohol = 0;

        for(int i = 0; i<this.osszetevok.Length; i++)
            {
                if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Alkohol)
                {
                    allAlcohol += osszetevok[i].Amount;
                }
            }

            return $"-- Teljes alkoholtartalom: {allAlcohol} ml --";
        }

        public string MaximalisMennyiseg()
        {
            int alc = 0;
            int foly = 0;
            int egy = 0;
            string result = "";

            for (int i = 0; i < this.osszetevok.Length; i++)
            {
                if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Alkohol)
                {
                    alc++;
                }
                else if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Folyadek)
                {
                    foly++;
                }
                else if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Egyeb)
                {
                    egy++;
                }
            }

            int max = Math.Max(alc, Math.Max(foly, egy));

            if (alc == max)
            {
                if (result != "") result += ", ";
                result += "Alkohol";
            }
            if (foly == max)
            {
                if (result != "") result += ", ";
                result += "Folyadek";
            }
            if (egy == max)
            {
                if (result != "") result += ", ";
                result += "Egyeb";
            }

            return result;
        }

        public Osszetevok[] Csoportosit()
        {
            int counter = 0;

            Osszetevok[] temp = new Osszetevok[this.osszetevok.Length];

            
                for (int i = 0; i < this.osszetevok.Length; i++)
                {
                    if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Alkohol)
                    {
                        
                        temp[counter] = this.osszetevok[i];
                        counter++;
                    }
                }

                for (int i = 0; i < this.osszetevok.Length; i++)
                {
                    if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Folyadek)
                    {

                        temp[counter] = this.osszetevok[i];
                        counter++;
                    }
                }
                for (int i = 0; i < this.osszetevok.Length; i++)
                {
                    if (this.osszetevok[i].OsszetevoFajta == OsszetevoFajta.Egyeb)
                    {

                        temp[counter] = this.osszetevok[i];
                        counter++;
                    }
                }

                

             
            return temp;
        }

        public string ReceptNyomtatas()
        {
            Osszetevok[] toPrint = new Osszetevok[this.osszetevok.Length];
            toPrint = Csoportosit();
            string receptName = "";

            for (int i = 0; i < toPrint.Length; i++)
            {
                receptName += toPrint[i].Szovegkent();;
                receptName += "\n";
            }
            receptName += OsszAlkoholtartalom();

            return receptName;
        }



    }
}