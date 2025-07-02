using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ZH2Practice
{
    public class Time:IComparable
    {
        int hours;
        int minutes;
        int seconds;

        public int Hours { get { return hours; }
            set {  
                
                if( value <0 || value > 3)
                {
                    throw new TimeException("Nem megfelelő érték");
                }
                hours = value;
                ; }
           }
        public int Minutes
        {
            get { return minutes; }
            set
            {

                if (value < 0 || value > 59)
                {
                    throw new TimeException("Nem megfelelő érték");
                }
                minutes = value;
                ;
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {

                if (value < 0 || value > 59)
                {
                    throw new TimeException("Nem megfelelő érték");
                }
                seconds = value;
                ;
            }

        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time(int minutes, int secondc): this (0, minutes, secondc)
        {
        }

        public override string ToString()
        {
            string temp = $"{(this.Minutes>9 ? this.Minutes : "0"+this.Minutes)}:" +
                        $"{(this.Seconds > 9 ? this.Seconds : "0"+this.Seconds)}";
            if(Hours > 0)
            {
                temp= $"0{this.Hours}:{temp}";
            }

            return temp;
        }
        public static Time TimeParse(string input)
        {
            string[] temp = input.Split(':');
            Time time = null;

            if (temp.Length == 2) 
            {
               return time = new Time(int.Parse(temp[0]), int.Parse(temp[1])); 
            }
            else if (temp.Length == 3)
            {
                return time = new Time(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));

            }
            else
            {
                throw new TimeException("Hiba a beolvasás során");
            }
            
        }

        public int CompareTo(object? obj)
        {
            if (obj is Time t)
            {
                int current = this.Hours * 60 * 60 + this.Minutes * 60 + this.Seconds;
                int temp = t.Hours * 60 * 60 + t.Minutes * 60 + t.Seconds;

              return temp.CompareTo(current);
            }
            else
            {
                throw new TimeException("Az elemek nem összehasonlíthatóak");
            }
        }


    }
}
