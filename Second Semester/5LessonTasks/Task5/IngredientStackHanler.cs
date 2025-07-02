using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class IngredientStackHanler
    {

        public IIngredientStack IngredientStack {  get; private set; }

        public IngredientStackHanler(IIngredientStack ingredientStack)
        {
            IngredientStack = ingredientStack;
        }

        public FoodIngredient[] AddItems(FoodIngredient[] foodIngredients)
        {
            FoodIngredient[] ingredient = new FoodIngredient[foodIngredients.Length];
            try
            {
                for (int i = 0; i < foodIngredients.Length; i++)
                {
                    IngredientStack.Push(foodIngredients[i]);
                }
            }
            catch (StackFullException) { Console.WriteLine("Hiba"); }


            return ingredient;
        }

        public FoodIngredient GetFoodIngredient()
        {
            FoodIngredient foodIngredient = this.IngredientStack.Pop();
            foodIngredient.Quantity = 100;
            return foodIngredient;
        }
    }
}
