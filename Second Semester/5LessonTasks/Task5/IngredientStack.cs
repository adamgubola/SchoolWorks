using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class IngredientStack : IIngredientStack
    {

        public FoodIngredient[] FoodIngredients { get; private set; }

        private int idx = 0;

        public IngredientStack(int num)
        {
            this.FoodIngredients = new FoodIngredient[num];
        }

        public bool Empty()
        {
            if (idx <= 0) { return true; }
            return false;
        }

        public void Push(FoodIngredient newItem)
        {

            if (idx < FoodIngredients.Length)
            {
                FoodIngredients[idx] = newItem;
                idx++;
            }

            else
            {
                throw new StackFullException(this, newItem);

            }

        }

        public FoodIngredient Pop()
        {
            FoodIngredient temp;


            if (!Empty())
            {
                temp = FoodIngredients[idx - 1];
                idx--;
                return temp;
            }

            else
            {
                throw new StackEmptyException(this);

            }
        }




        public FoodIngredient Top()
        {

            FoodIngredient temp;


            if (!Empty())
            {
                temp = FoodIngredients[idx - 1];
                return temp;
            }

            else
            {
                throw new StackEmptyException(this);
            }

        }

    }
}
