using System;

namespace _002_Adapter
{
    class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flies 100 Metres");
        }
    }
}
