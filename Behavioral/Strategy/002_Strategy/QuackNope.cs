using System;

namespace _002_Strategy
{
    internal class QuackNope : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}