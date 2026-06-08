namespace BridgeExample
{
    abstract class Engine(string name, string type)
    {
        protected readonly string type = type;

        public string Name { get; } = name;

        public string Type => type;

        public string? Description { get; init; }

        public double Power { get; init; } = 1.1;

        public abstract void Start();

    }
}
