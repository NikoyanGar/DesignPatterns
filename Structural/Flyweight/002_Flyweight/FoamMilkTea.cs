using System;

namespace _002_Flyweight
{
    public class FoamMilkTea : IBeverage
    {

        public FoamMilkTea()
        {
            Console.WriteLine("Initializing a Foam Milk Tea instance");
        }

        public void Drink()
        {
            Console.WriteLine("hmmm... this is foam milk tea");
        }
    }
}