using System;

namespace _002_Strategy
{
    class FlyNope : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
