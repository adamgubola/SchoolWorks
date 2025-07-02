using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Renting
{
    internal class ApartmentHouse
    {
        public IRealEstate[] realEstate { get; private set; }
        public Flat [] flats { get; private set; }
        public Garage [] garages { get; private set; }

        private int garageNumber;
        private int flatNUmber;
        private int realEstateNum;

        public int RealEstateNum
        {
            get { return realEstateNum; }
            set { realEstateNum = value; }
        }



        public int FlatNumber
        {
            get { return flatNUmber; }
            set { flatNUmber = value; }
        }


        public int GarageNumber
        {
            get { return garageNumber; }
            protected set { garageNumber = value; }
        }

        public ApartmentHouse(int flat, int garage)
        {
            this.flats = new Flat[flat];
            this.garages = new Garage[garage];
            this.realEstate = new IRealEstate[flat+garage];
            FlatNumber = 0;
            GarageNumber = 0;
            RealEstateNum = 0;

        }
        public bool Add(Flat flat, Garage garage)
        {
            if (this.FlatNumber < this.flats.Length && this.GarageNumber< this.garages.Length) 
            {

                this.flats[this.FlatNumber]=flat;
                this.realEstate[this.RealEstateNum] = flat;
                this.FlatNumber++;
                this.RealEstateNum++;
                this.garages[this.GarageNumber]=garage;
                this.realEstate[this.RealEstateNum] = garage;
                this.garageNumber++;
                this.RealEstateNum++;
                return true;
            }

            return false;
        }

        public bool Add(Flat flat)
        {
            if (this.FlatNumber < this.flats.Length || this.RealEstateNum < this.realEstate.Length)
            {

                this.flats[this.FlatNumber] = flat;
                this.realEstate[this.RealEstateNum]=flat;
                this.FlatNumber++;
                this.RealEstateNum++;
                
                return true;
            }

            return false;
        }
        public bool Add(Garage garage)
        {
            if (this.GarageNumber < this.garages.Length || this.RealEstateNum< this.realEstate.Length)
            {

                this.garages[this.GarageNumber] = garage;
                this.realEstate[this.RealEstateNum]=garage;
                this.garageNumber++;
                this.RealEstateNum++;
                return true;
            }

            return false;
        }

        public bool Add(IRealEstate real) 
        { 
        if(real is Flat f)
            {
                return this.Add(f);
            }
        else if(real is  Garage g)
            {
                return this.Add(g);
            }
            return false;
        
        }

        public bool Add(object obj)
        {
            if(obj is IRealEstate realEstate)
            {
                return this.Add(realEstate);
            }
            return false;
        }
        public int TotalValue()
        {
            int sum = 0;

            for (int i = 0; i < this.realEstate.Length; i++)

            {
                if (this.realEstate[i] is Flat f) {

                    if (f.InhabitantsCount > 0)
                    {
                        sum += f.TotalValue();
                    } 
                }
                else if(this.realEstate[i] is Garage g){
                    
                    if (g.IsOccupied)
                {
                    sum += g.TotalValue();
                }
            
                }
            }
            return sum;
        }

        public static ApartmentHouse LoadFromFile()
        {
            string path = "Renting.txt";

            string [] datas = File.ReadAllLines(path);
            int A = 0;
            int G = 0;

            for(int j =0; j<datas.Length; j++)
            {
            if (datas[j].ToLower().Contains("csaladiapartman") || datas[j].ToLower().Contains("alberlet"))
                {
                    A++;
                }
            else if(datas[j].ToLower().Contains("garazs"))
                {
                    G++;
                }

            }
                


            ApartmentHouse apartmentHouse = new ApartmentHouse(A, G);

            for (int i = 0; i < datas.Length; i++) 
            {
                string[] splitted = datas[i].Split(' ');

                if (splitted[0].ToLower() == "alberlet")
                {
                    Lodgings lodgings = new Lodgings(int.Parse(splitted[3]), int.Parse(splitted[2]),
                                                     int.Parse(splitted[1]));
                    apartmentHouse.Add(lodgings);
                    
                    
                }
                else if(splitted[0].ToLower() == "csaladiapartman")
                {
                    FamilyApartment family = new FamilyApartment(int.Parse(splitted[3]), int.Parse(splitted[2]),
                                                     int.Parse(splitted[1]));
                    apartmentHouse.Add(family);

                }
                else if (splitted[0].ToLower() == "garazs")
                {
                    Garage garage = new Garage((splitted[3].ToLower().Equals("futott")? true : false),
                                                    int.Parse(splitted[2]),
                                                     int.Parse(splitted[1]));
                    apartmentHouse.Add(garage);

                }

            }

            return apartmentHouse;

        }
    }
}
