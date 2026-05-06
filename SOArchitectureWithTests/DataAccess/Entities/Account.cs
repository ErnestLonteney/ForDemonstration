namespace DataAccess.Entities
{
    public class Account : ContactEntity
    {
        public Account()
        {
        }

        public Account(string name)
        {
            Name = name;
        }

        public override string FullName => Name;


        public string Name { get; private set; }

        public string? ShortName { get; set; } 
        

        public ICollection<Contact> Contacts { get; set; }  = new List<Contact>();
    }
}
