using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BurgerFactory
    {
        public Burger createCheeseBurger()
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Bun(),
                new Cheese(),
                new BeefPatty()
            };

            return new Burger(ingredients);
        }

        public Burger createDeluxeCheeseBurger()
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Bun(),
                new Cheese(),
                new Tomato(),
                new BeefPatty(),
                new Lettuce()
            };

            return new Burger(ingredients);
        }

        public Burger createVeganBurger()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            ingredients.Add(new Bun());
            ingredients.Add(new SpecialSauce());
            ingredients.Add(new VeggiePatty());


            return new Burger(ingredients);
        }
    }
}
