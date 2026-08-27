namespace Decorator;

public class Gun : Weapon
{
    public override void Fire()
    {
        Console.WriteLine($"{Person.LastName} is firing a gun");
    }

    public void Clean()
    {
        Console.WriteLine($"{Person.LastName} is cleaning the gun");
    }
}
