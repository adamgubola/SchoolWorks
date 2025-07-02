using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Running_Race
{
    internal class Runner
    {
        private static Random rand = new Random();
        private string name;
        private int pace;
        private double distancePerMin;
        private int time;
        private bool giveUp;
        private double distance;


        public string Name { get { return name; } set { name = value; } }

        public int Pace
        {
            get { return pace; }
            private set
            {
                if (value >= 3 && value <= 9)
                {
                    pace = value;
                    distancePerMin = 1.0 / value;
                }

                else
                {
                    throw new Exception("Nem jó értéket adtál meg a tempónak ");
                }
            }
        }
        public double Distance { get { return distance; } set { distance = value; } }

     

        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public bool GiveUp
        {
            get { return giveUp; }
            set { giveUp = value; }
        }

        public Runner(string name, int pace) {
            this.distance = 0;
            this.time = 0;
            this.giveUp = false;
            this.name = name;
            Pace = pace;
        }
        public int Move() {

            int temp = 0;

            if (this.time > 180) { temp = 5; }
            else if (this.time > 120) { temp = 3; }
            else if (this.time > 90) { temp = 2; }
            else if (this.time > 60) { temp = 1; }

            int tempRand = rand.Next(0,1000);

            if (temp > tempRand) { GiveUp = true; } else { GiveUp = false; }
            {
                
            }

            this.distance += distancePerMin;
            time++;

            if(this.distance % 1000 == 0) { return 1; } else { return 0; }

        }

        public void Display()
        {
            string result= string.Empty;

            result += $"Név: {this.name} {(this.giveUp ? "Feladta: igen" : "Feladta: nem")} " ;

            Console.WriteLine(result);
        }

       


    }
}
