namespace MediatorExample
{
    internal class Distributor : Colleague
    {
        private double haveOnSellInKg;
        private const int sellTimeMs = 6000;
        private const double defaultOrderAmountKg = 100.0;
        private const string distributorColor = "\x1b[33m"; // Жовтий
        private const string resetColor = "\x1b[0m";

        public Distributor(Mediator mediator) : base(mediator)
        {
        }

        public Task Run()
        {
            return Task.Run(async () =>
            {
                while (true)
                {
                    if (haveOnSellInKg > 0)
                    {
                        await Task.Delay(sellTimeMs);
                        Sell(haveOnSellInKg);
                        haveOnSellInKg = 0;
                    }
                    else
                    {
                        Console.WriteLine($"{distributorColor}[DISTRIBUTOR] 📦 Ordering new ketchup: {defaultOrderAmountKg} kg{resetColor}");
                        Send(defaultOrderAmountKg);
                        await Task.Delay(1000);
                    }
                }
            });
        }   

        public void OrderKetchup(double message)
        {
            Send(message);
        }

        public void SupplyKetchup(double message)
        {
            haveOnSellInKg += message;
        }

        public void Sell(double amount)
        {
            Console.WriteLine($"{distributorColor}[DISTRIBUTOR] 💰 Sold: {amount} kg of ketchup to customers!{resetColor}");
        }

        public override void Request(double message)
        {
            throw new NotImplementedException();
        }

        public override void Notify(double message)
        {
            SupplyKetchup(message);
            Console.WriteLine($"{distributorColor}[DISTRIBUTOR] ✅ Received supply: {message} kg of ketchup{resetColor}");
        }
    }
}
