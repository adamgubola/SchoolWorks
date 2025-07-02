using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PracticeTasks
{
    public class Runner
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
            this.distanceFromStart += userNumber * speed;
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
}
