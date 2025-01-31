using System;

namespace _002_Mediator
{
    class Tester : Colleague
    {
        public Tester(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine($"Message to tester: {message}");
        }
    }
}