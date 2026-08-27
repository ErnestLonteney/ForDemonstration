namespace Decorator;

public abstract class Costume : Person
{
    public Person? WrappedPerson { get; set; }

    public override void Introduce()
    {
        if (WrappedPerson == null)
            throw new InvalidOperationException("WrappedPerson must be set before calling Introduce()");

        WrappedPerson.Introduce();
    }
}
