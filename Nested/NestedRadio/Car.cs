namespace NestedRadio
{
    abstract class Car
    {
        protected CarPart[] parts;
        protected int currentIndex = 0;

        protected Car(string model, string brand)
        {
            parts = new CarPart[20];

            Model = model;
            Brand = brand;  
        }

        public double CurrentSpeed { get; set; }

        public string Model { get; set; }
        public string Brand { get; set; }
        public abstract double VolumeEngine { get; protected set; }
        
        public abstract void Start();
        public virtual void Stop() => CurrentSpeed = 0;
        public virtual void Accelerate(double step, double distance = Double.MaxValue) => CurrentSpeed += step;
        public virtual void Decelerate(double step) => CurrentSpeed -= step;
        public abstract void TurnLeft(double radius);
        public abstract void TurnRight(double radius);

        public abstract void AddRadioToCar();

        public abstract class CarPart
        { 
            public string Name { get; protected set; }
        }

        public abstract CarPart this[string name] { get; }

        public abstract class Radio : CarPart
        {
            protected Radio()
            {
                Name = "Radio";
            }

            public string Model { get; set; }

            public abstract void TurnOn();

            public abstract void TurnOff();
        }
    }
}
