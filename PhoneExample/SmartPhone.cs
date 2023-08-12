namespace PhoneExample
{
    class SmartPhone : Phone, IIdentifier, IDisposable
    {
        private readonly Guid clientId;
        public string Processor { get; }

        public Guid Id => clientId;

        public SmartPhone(string processor, string brand, string model, string color) 
            : base(brand, model, color)
        {
            Processor = processor;
            clientId = Guid.NewGuid();  
        }

        public override void MakeACall(Guid contactId)
        {
            base.MakeACall(contactId);
            Console.WriteLine("with video");
        }

        public override void Initate()
        {
            imay = GenarateImay();
            Console.WriteLine($"Assigned imay {imay}");
        }

        private static string GenarateImay()
        {
            string imay = string.Empty;
            var randomizer = new Random();

            for (int i = 0; i < 15; i++)
            {
                int number = randomizer.Next(9);
                imay += number; 
            }

            return imay;
        }

        public void Dispose()
        {
            Console.WriteLine("Close db connection");
            Console.WriteLine("Remove removed data");
        }
    }
}
