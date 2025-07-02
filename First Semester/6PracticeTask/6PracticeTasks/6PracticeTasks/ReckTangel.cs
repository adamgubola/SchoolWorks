using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PracticeTasks
{
    public class ReckTangel
    {
        int width;
        int height;
        string colour;

        public ReckTangel(int width, int height, string colour)
        {
            this.width = width;
            this.height = height;
            this.colour = colour;
        }

        private int Area() { return width * height; }

        public bool Isvalid()
        {
            bool isValid = Area() != 0;

            return isValid;
        }

        public void Draw(int x, int y)
        {

            if (Isvalid())
            {

                try
                {
                    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colour, true);

                }
                catch (Exception)
                {
                    Console.WriteLine("Ismereen szín");
                    Console.ResetColor();

                }
                for (int i = 0; i < height; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.WriteLine(new string('*', width));

                }
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("A négyzet üres");

            }

        }
    }
}