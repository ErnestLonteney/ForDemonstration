namespace ConsoleApp1
{
    internal class Program
    {
        static void Greet(Person person)
        {
            Console.WriteLine($"Dear {person.FirstName} {person.LastName}");
            Console.WriteLine("Happy New Year and Merry Cristmas");

            Console.WriteLine($"Sent to {person.Email}");

            if (person is Emploee)
            {
                Emploee ourEmploee = (Emploee)person;
                Console.WriteLine($"Your salary has been increased to { ourEmploee.Sallary *= 1.1}");
            }

            Console.WriteLine(new String('*', 50));
        }

        static void Main()
        {
          //тип назва значення
            int a = 10;
            // тип назва     значення 
            Person person1 = new Person("Jeffry", "Rihter")
            {
                PhoneNumber = "+389055634564"
            };
            Console.WriteLine(person1.FirstName);

            Person person2 = new Person("Bob", "Jenckins", "+38093434");
            Console.WriteLine(person2.FirstName);

            Emploee galyna = new Emploee("Galyna", "Felinskla", 38900, "QA")
            {
                Email = "galyna@gmail.com"
            };
            galyna.GetInfo();

            Customer customer = new Customer("Jane", "Watson");

            Greet(person1);
            Greet(person2);
            Greet(galyna);
            Greet(customer);
        }
    }
}
