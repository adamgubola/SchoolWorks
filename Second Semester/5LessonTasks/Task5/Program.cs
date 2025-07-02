using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodIngredient foodIngredient =new FoodIngredient("Tej", 3, Units.liter);

            Console.WriteLine(foodIngredient.ToString());
        }
    }
}
