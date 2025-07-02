using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffaloHunter
{
    internal class Buffalo
    {
        static Random random = new Random();

        int actualPositionX = 1;
        int actualPositionY = 1;

        bool isActive = true;


        public int X { get { return actualPositionX; } }
        public int Y { get { return actualPositionY; } }
        


        public void Move(Field field)
        {


            string temp = field.AllowedPositin(actualPositionX, actualPositionY);

            if (temp.Equals("down") && isActive)
            {
                actualPositionY += 1;
            }
            else if (temp.Equals("right") && isActive)
                {
                    actualPositionX += 1;
                }
            else if (temp.Equals("everywhere") && isActive) {

                int randStep = random.Next(1, 4);


                if (randStep == 1) { actualPositionX += 1; }
                else if (randStep == 2) { actualPositionY += 1; }
                else if (randStep == 3) { actualPositionX += 1; actualPositionY += 1; }
            }
            temp = "";
        }
        public void Deactivate() { isActive = false; }

        public void Show()
        {
            Console.SetCursorPosition(actualPositionX, actualPositionY);
            if (isActive)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("B");
                Console.ResetColor();
            }
            else if (!isActive)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("B");
                Console.ResetColor();
            }
        }


    }
}
