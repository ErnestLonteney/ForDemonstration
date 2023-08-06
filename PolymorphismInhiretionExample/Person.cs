namespace PolymorphismInhiretionExample
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Person(int id)
        {
            Id = id;
        }

        public virtual string GetPersonalData() =>
            @$"First Name - {FirstName}
Last Name - {LastName}
Email - {Email}
Phone - {Phone}
Address - {Address}";
    }
}
