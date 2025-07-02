using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class StackFullException : StackException
    {
        public StackFullException(IngredientStack ingredientStack, FoodIngredient foodIngredient) : base(ingredientStack)
        {
            FoodIngredient = foodIngredient;
        }

        public FoodIngredient FoodIngredient { get; private set; }

       
    }
}
