using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZH2Practice;

namespace ZH2Practice
{
    public class RunnerWithTime : IComparable
    {
        public string Name { get; private set; }
        public Time TimeForRunner { get; private set; }

        public RunnerWithTime(string name, string timeInp)
        {
            Name = name;
            TimeForRunner = Time.TimeParse(timeInp);
        }

        public static RunnerWithTime Parse(string input)
        {
            string[] temp = input.Split(',');

            if (temp.Length == 2)
            {

                return  new RunnerWithTime(temp[0], temp[1]);
            }
            else
            {
                throw new ArgumentException("Hiba a futó létrehozásakor");
            }
        }

        public int CompareTo(object? obj)
        {
            if (obj is RunnerWithTime runner)
            {
                if (runner.TimeForRunner.CompareTo(this.TimeForRunner) == 0)
                {
                    return runner.Name.CompareTo(this.Name);
                }
                else
                {
                    return runner.TimeForRunner.CompareTo(this.TimeForRunner);
                }
            }
            else
            {
                throw new ArgumentException("Nem lehet összehasonlítani a futókat");
            }
        }

        public override string? ToString()
        {
            return $"{this.Name} ({this.TimeForRunner.ToString()})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is RunnerWithTime runner)
            {
                return runner.TimeForRunner.CompareTo(this.TimeForRunner) == 0 &&
                    runner.Name.CompareTo(this.Name) == 0;
                
            }
            else
            {
                throw new ArgumentException("Nem lehet összehasonlítani a futókat");
            }
            ;
        }
    }
}
