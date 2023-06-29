namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            BurgerBuilder builder = new BurgerBuilder();

            Burger cheeseBurger = builder
                .addBun(new Bun("sesame"))
                .addPatty(new Patty("beef"))
                .addCheese(new Cheese("cottage cheese"))
                .build();

            builder = new BurgerBuilder();

            Burger veganBurger = builder
                .addBun(new Bun("flaxseed"))
                .addPatty(new Patty("veggie"))
                .addSauce(new Sauce("mayo"))
                .build();

            cheeseBurger.getIngredients();
            veganBurger.getIngredients();

        }
    }
}