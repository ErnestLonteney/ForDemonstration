namespace Decorator;

public abstract class Weapon : Person
{
    public Person? Person { get; set; }

    public abstract void Fire();
}
