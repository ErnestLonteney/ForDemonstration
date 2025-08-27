namespace EmploeeTypes
{
    public class Customer
    {
        public Customer(string firstName, string lastName, string inn)
        {
            FirstName = firstName;
            LastName = lastName;
            if (inn.Length == 9)
            {
                INN = inn;
            }
            else
            {
                INN = "Wrong INN";
            }
        }

        public int Id { get; set; }

        private string firstName;
        public string FirstName 
        {
            get => firstName;
            set
            {     //Andriy
                if (value.Length > 3)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "Not valid first name";
                }
            }
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length > 3)
                {
                    lastName = value;
                }
                else
                {
                    lastName = "Not valid first name";
                }
            }
        }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string INN { get; }

        public CustomerType Type { get; init; }

        public DateTime DateOfBirth { get; init; }
    }
}
