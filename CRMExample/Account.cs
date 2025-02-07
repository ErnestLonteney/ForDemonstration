namespace CRMExample
{
    internal class Account
    {
        public Guid Id { get; }

        public string Name { get; }

        public Address Address { get; set; }

        public ContactInfo[] ContactInfo { get; set; } 

        public Contact[] Contacts { get; set; } = [];

        public Account(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
