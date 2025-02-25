﻿using _002_Factory.Pizza;

namespace _002_Factory
{
    class ChicagoPizzaFactory : PizzaFactory
    {
        private readonly string chicagoCheese = "Chicago Cheese";
        private readonly string chicagoClam = "Chicago Clam";
        private readonly string chicagoVeggie = "Chicago Veggie";

        protected override Pizza.Pizza Create(PizzaType type)
        {
            Pizza.Pizza pizza;
            IIngredientsFactory ingredients = new ChicagoIngredientsFactory();

            if (type == PizzaType.Cheese)
            {
                pizza = new CheesePizza(ingredients);
                pizza.Name = chicagoCheese;
            }
            else if (type == PizzaType.Clam)
            {
                pizza = new ClamPizza(ingredients);
                pizza.Name = chicagoClam;
            }
            else
            {
                pizza = new VeggiePizza(ingredients);
                pizza.Name = chicagoVeggie;
            }
            pizza.Color = "red";
            return pizza;
        }
    }
}
