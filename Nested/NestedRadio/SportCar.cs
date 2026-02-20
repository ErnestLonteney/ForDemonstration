namespace NestedRadio
{
    class SportCar : Car
    {

        private readonly SportCarRadio radio;

        public SportCar(string model, string brand, double engineVolume) 
            : base(model, brand)
        {
            VolumeEngine = engineVolume;  
            radio = new SportCarRadio();

        }

        public override CarPart this[string name]
        {
            get 
            {
                for (int i = 0; i < currentIndex; i++)
                    if (parts[i].Name == name)
                        return parts[i];

                return null;
            }
        }

        public override double VolumeEngine { get; protected set; }

        private void PassDistance(double distance)
        {
            var parktronic = this["Parktronic"] as Parktronik;

            if (parktronic != null)
            {
                parktronic.Distance = distance;
            }
        }   

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
            var parktronic = this["Parktronic"] as Parktronik;
            if (parktronic != null)
            {
                Task.Run(parktronic.Scan);
            }

            Console.WriteLine("Car has started");
        }


        public override void Stop()
        {
            base.Stop();
            Console.WriteLine("Car has stopped");
            var parktronic = this["Parktronic"] as Parktronik;

            if (parktronic != null)
            {
                parktronic.StopScan();
            }
        }

        public override void Accelerate(double step, double distance)
        {
            base.Accelerate(step * 2);
            PassDistance(distance);
        }

        public override void TurnLeft(double radius)
        {
            Console.WriteLine($"Car has turned lefn on {radius}");
        }

        public override void TurnRight(double radius)
        {
            Console.WriteLine($"Car has turned right on {radius}");
        }

        private class SportCarRadio : Radio
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
            private bool isStoppedScan = false;

            public double Distance { get; set; } = double.MaxValue; 

            public Parktronik()
            {
                Name = "Parktronic";     
            }

            public void Scan()
            {
                while (!isStoppedScan)
                {
                    if (Distance < 20)
                        Console.WriteLine("Beep");

                    Task.Delay(500);
                }
            }

            public void StopScan() => isStoppedScan = true;
        }
    }
}
