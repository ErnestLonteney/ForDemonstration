namespace BridgeExample
{
    class DieselEngine(string name) : Engine(name, "Diesel")
    {
        public override void Start()
        {
            Console.WriteLine($"The {Name} engine is starting.");
        }
    }
}
