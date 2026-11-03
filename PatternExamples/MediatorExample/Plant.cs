namespace MediatorExample
{
    internal class Plant : Colleague
    {
        private double _needToProduceInKg;
        private const int productionTimeMs = 7000;
        private const string plantColor = "\x1b[35m"; 
        private const string resetColor = "\x1b[0m";

        public Plant(Mediator mediator) : base(mediator)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (_needToProduceInKg > 0)
                    {
                        await Task.Delay(productionTimeMs);
                        Produce(_needToProduceInKg);
                        _needToProduceInKg = 0;
                    }
                    else
                    {
                        await Task.Delay(500); // Невелика затримка для уникнення активного очікування
                    }
                }
            });
        }

        public override void Request(double message)
        {
            _needToProduceInKg = message;
            Console.WriteLine($"{plantColor}[PLANT] 🏭 Received order: produce ketchup from {message} kg of tomatoes{resetColor}");
        } 

        public void Produce(double amount)
        {
            Console.WriteLine($"{plantColor}[PLANT] 🍅 Produced: {amount} kg of ketchup{resetColor}");
            Send(amount);
        }

        public override void Notify(double message)
        {
            throw new NotImplementedException();
        }
    }
}
