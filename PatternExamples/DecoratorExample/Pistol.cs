namespace Decorator;

internal class Pistol : Weapon
{
    public override void Fire()
    {
        Console.WriteLine($"{Person?.LastName} is firing a pistol");
    }

    public void Reload()
    {
        Console.WriteLine($"{Person?.LastName} is reloading the pistol");
    }
}
