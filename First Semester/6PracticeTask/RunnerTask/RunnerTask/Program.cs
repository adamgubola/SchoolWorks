using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerTask
{


    class Runner
    {

        string name;
        int number;
        int speed;
        int distanceFromStart;
        public Runner(string name, int number, int speed) 
        {
            this.name = name;
            this.number = number;
            this.speed = speed;
            this.distanceFromStart = 0;
        }

        public void RefreshDistance(int userNumber)
        {
            this.distanceFromStart+= userNumber*speed;
        }

        public void show()
        {
            int x = this.number;
            int y = this.distanceFromStart;

            Console.SetCursorPosition(y, x);
            Console.Write(name[0]);
        }

        public int GetDistance() 
        {
                return this.distanceFromStart;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int finish = 40;

            Runner run1 = new Runner("Adam", 10, 3);
            Runner run2 = new Runner("John", 5, 4);

            do
            {
                run1.RefreshDistance(2);
                run2.RefreshDistance(2);

                run1.show();
                run2 .show();

            }while (run1.GetDistance() <= finish || run2.GetDistance()<= finish);
        }
    }
}
