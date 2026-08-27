namespace Decorator;

public class ProtectiveCostume : Costume
{
    public ProtectiveCostume() { }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("Wearing protective costume.");
    }
}
