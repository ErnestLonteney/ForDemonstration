namespace MediatorExample
{
    internal abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(double message)
        {
            mediator.Send(message, this);
        }

        public abstract void Request(double message);

        public abstract void Notify(double message);
    }
}
