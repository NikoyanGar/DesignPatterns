using _002_Factory.Pizza;

namespace _002_Factory
{
    class NyPizzaFactory : PizzaFactory
    {
        private readonly string nyStyleCheese = "NY Style Cheese";
        private readonly string nyStyleClam = "NY Style Clam";
        private readonly string nyStyleVeggie = "NY Style Veggie";

        protected override Pizza.Pizza Create(PizzaType type)
        {
            Pizza.Pizza pizza;
            IIngredientsFactory ingredients = new NyIngredientsFactory();

            if (type == PizzaType.Cheese)
            {
                pizza = new CheesePizza(ingredients) { Name = nyStyleCheese };
            }
            else if (type == PizzaType.Clam)
            {
                pizza = new ClamPizza(ingredients) { Name = nyStyleClam };
            }
            else
            {
                pizza = new VeggiePizza(ingredients) { Name = nyStyleVeggie };
            }
            pizza.Color = "blue";
            return pizza;
        }
    }
}
