namespace Builder
{
    public class Burger
    {
        public Bun Bun { get; private set; }
        public Patty Patty { get; private set; }
        public Cheese Cheese { get; private set; }
        public Sauce Sauce { get; set; }

        public Burger setBun(Bun bun)
        {
            Bun = bun;
            return this;
        }

        public Burger setPatty(Patty patty)
        {
            Patty = patty;
            return this;
        }

        public Burger setCheese(Cheese cheese)
        {
            Cheese = cheese;
            return this;
        }

        public Burger setSauce(Sauce sauce)
        {
            Sauce = sauce;
            return this;
        }

        public void getIngredients()
        {
            Console.WriteLine($"{Bun?.GetType().Name}: " + Bun?.Name);
            Console.WriteLine($"{Patty?.GetType().Name}: " + Patty?.Name);
            Console.WriteLine($"{Cheese?.GetType().Name}: " + Cheese?.Name);
            Console.WriteLine($"{Sauce?.GetType().Name}: " + Sauce?.Name);
        }
    }
}
