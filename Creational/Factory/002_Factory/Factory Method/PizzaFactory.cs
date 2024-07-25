namespace _002_Factory
{
    abstract class PizzaFactory
    {
        public Pizza.Pizza Order(PizzaType type)
        {
            var pizza = Create(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza.Pizza Create(PizzaType type);
    }
}
