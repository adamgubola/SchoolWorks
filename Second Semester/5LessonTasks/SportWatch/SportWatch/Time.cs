using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportWatch
{
    public class Time
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public Time(int hours, int minutes, int seconds)
        {

            if (hours >= 0 && hours < 24) 
            {
                Hours = hours;
            }
            else
            {
                throw new HourException();
            }
            if (minutes >= 0 && minutes < 60)
            {
                Minutes = minutes;
            }
            else
            {
                throw new MinuteException();
            }
            if (seconds >= 0 && seconds < 60)
            {
                Seconds = seconds;
            }
            else
            {
                throw new SecondException();
            }

        }


        public Time(string inp):this(inp.Split(':'))
        {
        }

        public Time(string[] inp) : this(int.Parse(inp[0]), int.Parse(inp[1]), int.Parse(inp[2]))
        {
        }


        public static Time Parse(string inp)
        {
            string[] parse = inp.Split(':');

            if (parse.Length < 3) 
            {
            throw new TimeException();
            }
            else
            {
                return new Time(int.Parse(parse[0]),
                                int.Parse(parse[1]),
                                int.Parse(parse[2]));
            }
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }



    }
}
