namespace BridgeExample
{
    abstract class Car(string vin, Engine engine)
    {
        protected readonly Engine engine = engine;
        
        public required string Model { get; init; }

        public required string Make { get; init; }

        public string VIN { get; } = vin;

        public virtual void Start()
        {
            engine.Start(); 
        }
    }
}
