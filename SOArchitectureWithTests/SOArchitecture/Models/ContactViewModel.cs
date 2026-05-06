namespace SOArchitecture.Models
{
    public class ContactViewModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public AccountViewModel? Account { get; set; }
    }
}
