namespace Decorator
{
    public class WaterCostume : Costume
    {
        public WaterCostume() { }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Swimming while wearing a water costume.");
        }   
    }
}
