using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestComperable[] testComperables = new TestComperable[]
            //                                    {new TestComperable(3), new TestComperable(1),
            //                                    new TestComperable(5), new TestComperable(2),
            //                                    new TestComperable(4), new TestComperable(0)};


            //Array.Sort(testComperables);

            //for (int i = 0; i < testComperables.Length; i++)
            //{

            //    Console.WriteLine(testComperables[i].Age);

            ApartmentHouse apartment = ApartmentHouse.LoadFromFile();

            for (int i = 0; i < apartment.realEstate.Length; i++) 
            {
            Console.WriteLine(apartment.realEstate[i].ToString());

                Console.WriteLine(apartment.realEstate[i].TotalValue());
            
                
            
            }

            
            

            





                    
            }
        
    }
}
