namespace Builder
{
    public class Ingredient
    {
        public string Name { get; private set; }

        public Ingredient(string name)
        {
            Name = name;    
        }
    }

    public class Bun  : Ingredient
    {
        public Bun(string name) : base(name) { }
    }

    public class Patty : Ingredient
    {
        public Patty(string name) : base(name) { }
    }

    public class Cheese : Ingredient
    {
        public Cheese(string name) : base(name) { }
    }

    public class Sauce : Ingredient
    {
        public Sauce(string name) : base(name) { }
    }
}
