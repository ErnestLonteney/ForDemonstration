namespace BridgeExample
{
    class Sedan(string vin, Engine engine) : Car(vin, engine)
    {
        public byte NumberOfDoors { get; init; } = 4;
        
        public override void Start()
        {
            Console.WriteLine($"Push the button to start the sedan.");
            base.Start();
        }
    }
}
