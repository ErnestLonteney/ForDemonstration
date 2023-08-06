namespace PhoneExample
{
    public abstract class Phone
    {
        protected string imay;
        protected readonly uint countOfContacts;
        protected string[] contacts;

        public uint SizeOfMemory { get; private set; } = 12;
        public string Model { get; }
        public string Brand { get; }
        public string Color { get; } 

        public Phone(string brand, string model, string color)
        {
            Initate();
            countOfContacts = SizeOfMemory * 4;
            contacts = new string[countOfContacts];   
            Brand = brand;
            Color = color;  
            Model = model;  
        }

        public virtual void MakeACall(string contact)
        {
            int index = GetContactIndex(contact);
            if (index != -1)
                Console.WriteLine($"Calling to {contacts[index]}");
            else
                Console.WriteLine("Unknown contact");
        }

        public void AddContact(string name)
        {
            int contactIndex = GetEmptySpace();

            if (contactIndex != -1)
               contacts[contactIndex] = name;  
        }

        public void IncreaseMemory(uint newValue)
        {
            SizeOfMemory = newValue;    
        }

        private int GetEmptySpace()
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i] == null)
                    return i;   
            }

            return -1;
        }

        private int GetContactIndex(string contact)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].ToUpper() == contact.Trim().ToUpper())
                {
                    return i;   
                }
            }

            return -1;
        }

        public abstract void Initate();
    }
}
