using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffaloHunter
{
    internal class Game
    {
        Field fieldPlace;
        List<Buffalo> buffalos;
        int goodShoot = 0;

        public Game(int sizeOfGame, int numOfBuffalos)
        {
            this.fieldPlace = new Field(sizeOfGame);
            this.buffalos = new List<Buffalo>();
            for (int i = 0; i < numOfBuffalos; i++) { buffalos.Add(new Buffalo()); }
        }

        public bool IsOver() 
        {

            for (int i = 0; i < buffalos.Count; i++)
            {
                if (fieldPlace.TargerX - 1 == buffalos[i].X && fieldPlace.TargetY - 1 == buffalos[i].Y)
                {
                    return true;
                }
                else if (goodShoot == buffalos.Count()) { return true; }
            }
            return false;
        }

        private void VisualElements() 
        {
            Console.Clear();
            fieldPlace.Show();

            for (int i = 0; i < buffalos.Count; i++)
            {
                buffalos[i].Move(fieldPlace); buffalos[i].Show();
            }
         }


        private void Shoot()
        {
            int shootX;
            int shootY;

            Console.SetCursorPosition(0, fieldPlace.TargetY+2);
            Console.WriteLine("Add meg a célkoordinátákat először vízszintesen pl: 2");
            shootX = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a célkoordinátákat föggőlegesen pl: 3");
            shootY = int.Parse(Console.ReadLine());


            for (int i = 0;i < buffalos.Count; i++)
            {
                if (buffalos[i].X==shootX && buffalos[i].Y == shootY) 
                { 
                    buffalos[i].Deactivate();
                    goodShoot += 1;
                
                }
            }

        }

        public void run()
        {
            do
            {
                VisualElements();
                Shoot();

                Console.SetCursorPosition(0, fieldPlace.TargetY+2);
                Console.WriteLine("\n");
                Console.WriteLine("\n");

                Console.WriteLine("A játéknak vége");

            } while (!IsOver());
        }



    }



}
