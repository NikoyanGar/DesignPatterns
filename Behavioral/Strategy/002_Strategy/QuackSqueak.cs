using System;

namespace _002_Strategy
{
    class QuackSqueak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeeeak");
        }
    }
}
