namespace Task5
{
    public interface IIngredientStack
    {
        FoodIngredient[] FoodIngredients { get; }

        bool Empty();
        FoodIngredient Pop();
        void Push(FoodIngredient newItem);
        FoodIngredient Top();
    }
}