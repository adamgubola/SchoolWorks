using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WhatchA_Mole
{

    class Mole
    {
        int position;

        public int Position { get { return position; } }

        public void TurnUp()
        {
            Console.WriteLine();
            int high = Console.CursorTop;
            Console.SetCursorPosition(position, high-1);
            Console.Write("M");
                        
        }

        public void Hide(int x, int y)
        {
            Random random = new Random();
            position = random.Next(x, y);

        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            bool getIt = false;
            int userGess = 0;


            while (!getIt )
            {

                Mole mole = new Mole();
                mole.Hide(1, 20);

                Console.WriteLine("Add meg a tipped");
                try
                {
                    userGess = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                mole.TurnUp();

                if (userGess != mole.Position)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nem talált");
                }
                else 
                {
                    Console.WriteLine("Eltaláltad");
                    getIt = true;
                }

            }

        }
    }
}
