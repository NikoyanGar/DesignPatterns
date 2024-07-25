namespace _002_Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}