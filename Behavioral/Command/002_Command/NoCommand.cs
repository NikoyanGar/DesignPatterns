using System;

namespace _002_Command
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command Assigned");
        }

        public void Undo()
        {
            Execute();
        }
    }
}