using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffaloHunter
{
    internal class Field
    {
        int gameSize;
        int targetX;
        int targetY;

        public Field(int gameSize)
        {
            this.gameSize = gameSize;
            this.targetX = gameSize;
            this.targetY = gameSize;
        }

        public int TargerX
        {
            get { return targetX; }
        }
        public int TargetY
        {
            get { return targetY; }
        }

        public string AllowedPositin(int x, int y) 
        {
            string canDown = "down";
            string canRight = "right";
            string canEveryWhere = "everywhere";
            string noWhere = "nowhere";

            if (x+1 < targetX && y+1 < targetY) {  return canEveryWhere; }
           
            else if(x+1 < targetX && y+1 >= targetY) { return canRight; }

            else if(x+1 >= targetX && y+1 < targetY) { return canDown; }

            return noWhere;

        }
        public void Show()
        {
            for (int i = 0; i <= gameSize; i++)
            {
                if (i == 0 || i == gameSize)
                {
                    Console.SetCursorPosition(0, i);
                    for (int j = 0; j < targetX; j++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("|");
                    Console.SetCursorPosition(targetY, i);
                    Console.Write("|");
                }
            }
        }




    }
}