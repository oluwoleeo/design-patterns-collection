namespace Factory
{
    public class Burger
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Burger(List<Ingredient> ingredients)
        {
            _ingredients = ingredients;
        }

        public void getIngredients()
        {
            foreach (Ingredient ingredient in _ingredients)
            {
                Console.WriteLine("Ingredient: " + ingredient.GetType().Name);
                // Console.WriteLine("Ingredient: " + ingredient.ToString());
            }

            Console.WriteLine();
        }
    }
}
