namespace BridgeExample
{
    class GasolineEngine(string name) : Engine(name, "Gasoline")
    {
        public override void Start()
        {
            Console.WriteLine($"The {Name} engine is starting.");
        }
    }
}
