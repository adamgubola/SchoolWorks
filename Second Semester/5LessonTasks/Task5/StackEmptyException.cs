using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class StackEmptyException : StackException
    {
        public StackEmptyException(IngredientStack ingredientStack) : base(ingredientStack)
        {
        }
    }
}
