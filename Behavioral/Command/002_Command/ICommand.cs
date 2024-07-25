namespace _002_Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}