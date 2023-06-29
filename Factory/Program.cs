namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BurgerFactory burgerFactory = new BurgerFactory();

            Burger cheeseBurger = burgerFactory.createCheeseBurger();
            Burger deluxeCheeseBurger = burgerFactory.createDeluxeCheeseBurger();
            Burger veganBurger = burgerFactory.createVeganBurger();

            cheeseBurger.getIngredients();
            deluxeCheeseBurger.getIngredients();
            veganBurger.getIngredients();
        }
    }
}