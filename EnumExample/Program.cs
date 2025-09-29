namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Person person = new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Phone = "123-456-7890",
                Email = "mail@com.ua",
                TypeOfClient =  TypeOfClient.FizychnayaOsoba,
                TypeOfReliable = TypeOfReliability.Reliable

            };

            Person person2 = new Person
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Phone = "987-654-3210",
                TypeOfClient = TypeOfClient.UrOsoba,
                TypeOfReliable = TypeOfReliability.Reliable

            };

            Person person3 = new Person
            {
                Id = 3,
                FirstName = "Alice",
                LastName = "Johnson",
                Phone = "555-555-5555",
                TypeOfClient = TypeOfClient.FizychnayaOsobaPidpriyemets,
                TypeOfReliable = TypeOfReliability.Risky  
            };

            if (person3.TypeOfClient ==  TypeOfClient.UrOsoba)
            {
                Console.WriteLine("Юридична особа");
            }

            if (person3.TypeOfReliable == TypeOfReliability.Risky)
            {
                Console.WriteLine("Risky client");
            }
        }
    }
}
