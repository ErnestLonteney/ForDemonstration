namespace SOArchitecture.Models
{
    public class AccountViewModel
    {
        public string? Name { get; set; }


        public List<ContactViewModel> Contacts { get; set; } = new List<ContactViewModel>();
    }
}
