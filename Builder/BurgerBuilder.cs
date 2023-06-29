namespace Builder
{
    public class BurgerBuilder
    {
        private Burger burger = new Burger();

        public BurgerBuilder addBun(Bun bun)
        {
            burger.setBun(bun);
            return this;
        }

        public BurgerBuilder addPatty(Patty patty)
        {
            burger.setPatty(patty);
            return this;
        }

        public BurgerBuilder addCheese(Cheese cheese)
        {
            burger.setCheese(cheese);
            return this;
        }

        public BurgerBuilder addSauce(Sauce sauce)
        {
            burger.setSauce(sauce);
            return this;
        }

        public Burger build()
        {
            return burger;
        }
    }
}
