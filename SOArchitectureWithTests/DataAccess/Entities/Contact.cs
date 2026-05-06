namespace DataAccess.Entities
{
    public class Contact : ContactEntity
    {
        public Contact()
        {
        }

        public Contact(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string FullName  => $"{FirstName} {LastName}";

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;


        public Account? Account { get; set; }
    }
}
