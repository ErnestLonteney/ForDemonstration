namespace PhoneExample
{
    public abstract class Phone
    {      
        public int SizeOfMemory { get; private set; } = 12;
        public ContactBook ContactBook { get; }
        public string Model { get; }
        public string Brand { get; }
        public string Color { get; }

        protected string imay;
        protected readonly int countOfContacts;
        protected DateTime startCall;
        protected DateTime endCall;
        protected CallInfoRecord[] historyOfCalls;
        protected int index = 0;

        private const int CountOfRecords = 250;
        
        public Phone(string brand, string model, string color)
        {
            Initate();
            countOfContacts = SizeOfMemory * 4;
            ContactBook = new ContactBook(countOfContacts);
            historyOfCalls = new CallInfoRecord[CountOfRecords];
            Brand = brand;
            Color = color;  
            Model = model;  
        }

        public virtual void MakeACall(Guid contactId)
        {
            Contact foundContact = ContactBook[contactId];
            if (foundContact != null)
            {
                Console.WriteLine($"Calling to {foundContact.LastName} {foundContact.FirsName}");
                startCall = DateTime.Now;
            }
            else
                Console.WriteLine("Unknown contact");
        }

        public virtual void EndACall(Guid contactId)
        {
            endCall = DateTime.Now;
            AddRecordAboutCall(new CallInfoRecord
            {
                AnotherContact = ContactBook[contactId],
                IsComming = true,
                Duration = endCall - startCall, 
            });
        }

        private void AddRecordAboutCall(CallInfoRecord record)
        {
            void Clear()
            {
                for (int i = 0; i < historyOfCalls.Length; i++)
                    historyOfCalls[i] = null;
            }

                      
            if (index == 200)
            {
                Clear();
                index = 0;
            }

            historyOfCalls[index++] = record;
        }

        public void IncreaseMemory(int newValue)
        {
            SizeOfMemory = newValue;    
        }

        public abstract void Initate();

        public void GetHystoryOfCalls()
        {
            string result = String.Empty;

            for (int i = 0; i < historyOfCalls.Length; i++)
            {
                if (historyOfCalls[i] == null)
                    continue;

                result += $"{historyOfCalls[i].DateTime} - {historyOfCalls[i].AnotherContact.FirsName} {historyOfCalls[i].AnotherContact.LastName}\n";
            }

            Console.WriteLine(result);  
        }
    }
}
