using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            Cage cage = new Cage(5);
            Cage cage2 = new Cage(5);

            for (int i = 0; i < 5; i++) {

                cage.Add(new Animal("" + (char)('A' + i), true, 10, Species.Panda));
                cage2.Add(new Animal("" + (char)('G' + i), true, 10, Species.Dog));


            }

            Cage.HighestAnimalsInCages(cage, cage2, Species.Dog).Print();

            }
    }
}
