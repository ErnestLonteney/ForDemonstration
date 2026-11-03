namespace MediatorExample
{
    internal abstract class Mediator
    {
        public abstract void Send(double message, Colleague colleague);
    }
}
