namespace BridgeExample
    {
        class Crossover(string vin, Engine engine) : Car(vin, engine)
        {
        public byte NumberOfDoors { get; init; } = 7;

            public override void Start()
            {
                Console.WriteLine($"Sensor activation initiated for the crossover.");
                base.Start();
            }
        }
    }
