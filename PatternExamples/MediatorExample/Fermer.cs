namespace MediatorExample
{
    internal class Fermer : Colleague
    {
        private double _needToProduceInKg;
        private const int productionTimeMs = 5000;
        private const string farmerColor = "\x1b[32m"; // Зелений
        private const string resetColor = "\x1b[0m";

        public Fermer(Mediator mediator) : base(mediator)
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (_needToProduceInKg > 0)
                    {
                        await Task.Delay(productionTimeMs);
                        Grow(_needToProduceInKg);
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
            Console.WriteLine($"{farmerColor}[FARMER] 🌾 Received order: {message} kg of tomatoes{resetColor}");
        }

        public void Grow(double amount)
        {
            Console.WriteLine($"{farmerColor}[FARMER] 🌱 Produced: {amount} kg of tomatoes{resetColor}");
            Send(amount);
        }

        public override void Notify(double message)
        {
            throw new NotImplementedException();
        }
    }
}
