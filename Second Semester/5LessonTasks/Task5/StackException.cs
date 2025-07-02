using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
   public  class StackException : Exception
    {
        private FoodIngredient foodIngredient;

        public IngredientStack IngredientStack { get; private set; }

        public StackException(IngredientStack ingredientStack)
        {
            IngredientStack = ingredientStack;
        }

      
    }
}
