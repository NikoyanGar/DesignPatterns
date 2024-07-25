using System;

namespace _002_Strategy
{
    class QuackNormal : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
