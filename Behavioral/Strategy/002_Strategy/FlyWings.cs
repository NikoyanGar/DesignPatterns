using System;

namespace _002_Strategy
{
    class FlyWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flap Flap");
        }
    }
}
