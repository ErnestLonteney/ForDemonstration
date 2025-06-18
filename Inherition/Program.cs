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
            Person person1 = new Person("Jeffry", "Rihter")
            {
                PhoneNumber = "+389055634564"
            };
            Console.WriteLine(person1.GetInfo());

            //Person person2 = new Person("Bob", "Jenckins", "+38093434");
            //Console.WriteLine(person2.FirstName);

            Console.WriteLine(new String('-', 50));

            Emploee galyna = new Emploee("Galyna", "Felinskla", 38900, "QA")
            {
                PhoneNumber = "+344554645645",
                Email = "galyna@gmail.com"
            };
            Console.WriteLine(galyna.GetInfo());

            Person galynaAsPerson = galyna;

            Console.WriteLine(galynaAsPerson.GetInfo());

            Emploee bestEmploee = (Emploee)galynaAsPerson;

            Console.WriteLine(bestEmploee.GetInfo());

            Customer customer = new Customer("Jane", "Watson");

            Greet(person1);
            Greet(galyna);
            Greet(customer);
        }
    }
}
