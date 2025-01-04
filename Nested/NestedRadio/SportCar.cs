namespace NestedRadio
{
    class SportCar : Car
    {
        public SportCar(string model, string brand, double engineVolume) 
            : base(model, brand)
        {
            base.volumeEngine = engineVolume;  
        }

        public override CarPart this[string name]
        {
            get 
            {
                for (int i = 0; i< currentIndex; i++)
                    if (parts[i] != null)
                        return parts[i];

                return null;
            }
        }

        public override double VolumeEngine => volumeEngine;        

        public override void AddRadioToCar()
        {
            base.parts[base.currentIndex++] = new SportCarRadio();
        }

        public void AddParktronic()
        {
            base.parts[base.currentIndex++] = new Parktronik();
        }
  
        public override void Start()
        {
            Console.WriteLine("Car has started");
        }

        public override void Stop()
        {
            Console.WriteLine("Car has stopped");
        }

        public override void TurnLeft(double radius)
        {
            Console.WriteLine($"Car has turned lefn on {radius}");
        }

        public override void TurnRight(double radius)
        {
            Console.WriteLine($"Car has turned right on {radius}");
        }

        public class SportCarRadio : Radio
        {
            public override void TurnOff()
            {
                Console.WriteLine("Radio is turned off");
            }

            public override void TurnOn()
            {
                Console.WriteLine("Radio is turned on");
            }
        }

        class Parktronik : CarPart
        {
            private bool stopScan = false;

            public double Distance { get; private set; } = 100;

            public void SetDistance()
            { 
                Distance = 45;    
            }

            public Parktronik()
            {
                Name = "Parktronic";     
            }

            public void Scan()
            {
                while (!stopScan)
                {
                    if (Distance < 20)
                        Console.WriteLine("Beep");
                }
            }

            public void StopScan() => stopScan = true;
        }
    }
}
