using System.Security.Cryptography.X509Certificates;

namespace PolymorphismInhiretionExample
{
    internal class Program
    {
        static void SendMail(Person person)
        {
            if (person.Email != null)
                Console.WriteLine($"Send to {person.Email} Hello {person.LastName} {person.FirstName}!");
            if (person is Emploee emploee)
                Console.WriteLine($"Your salary is {emploee.Salary}");
            else
                Console.WriteLine("Good day!");
        }

        static void Main()
        {
            var people = new Person[]
            {  new Person(1)
               {
                    FirstName = "Mike",
                    LastName = "Little",
                    Address = "Sault Lake City",
                    Email = "person@mail.com",
                },
                new User(2, "kyle", "sweet09")
                {
                    FirstName = "Kyle",
                    LastName = "Strong",
                    Address = "Sault Lake City",
                    Email = "person2@mail.com",
                    Salary = 3000,

                },
                new Administrator(3, "admin", "12345")
                {
                    FirstName = "Kyle",
                    LastName = "Strong",
                    Address = "Sault Lake City",
                    Email = "person2@mail.com",
                    Salary = 3000,
                    Phone = "+456564365",
                    Position = "Administrator of database"
                },
                new Emploee(4)
                {
                    FirstName = "Jim",
                    LastName = "Kerry",
                    Address = "Sault Lake City",
                    Email = "person4@mail.com",
                    Salary = 9000,
                    Phone = "+234234234",
                    Position = "Seller"
                }
            };

            for (int i = 0; i < people.Length; i++)
            {
                string data = people[i].GetPersonalData();
                Console.WriteLine(data);
                SendMail(people[i]);
                Console.WriteLine(new String('-', 50));
            }

            Administrator globalUser = (Administrator)people[2];
            globalUser.FixIssue();

            Person adminDataLikePerson = globalUser as Person;
            // We cannot do this if we take admin as just person 
            // adminDataLikePerson.FixIssue();
        }
    }
}