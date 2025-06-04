namespace IntefacesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "123-456-7890",
                    Email = ""
                },
                new Teacher
                {
                    FirstName = "Jane",
                    LastName = "Smith",
                    Phone = "098-765-4321",
                    Email = "",
                    Subjects = new string[] { "Math", "Science" },
                    TitleOfPosition = "Senior Teacher",
                    Salary = 45567.89
                },
                new Teacher
                {
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Phone = "555-555-5555",
                    Email = "",
                    Subjects = new string[] { "Math", "Physics" },
                    TitleOfPosition = "Junior Teacher",
                    Salary = 344546.90
                },
                new Student
                {
                    FirstName = "Bob",
                    LastName = "Brown",
                    Phone = "111-222-3333",
                    Email = "",                  
                    GroupName = "Group A"
                },
                new Director
                {
                    FirstName = "Charlie",
                    LastName = "Davis",
                    Phone = "444-444-4444",
                    Email = "",
                    Department = "Science",
                    Salary = 100000,
                    TitleOfPosition = "Head of Science Department"
                }
            };

            for (int i = 0; i < people.Length; i++)
            {
                people[i].Introduce();
                people[i].RegisterInSystem();
                Console.WriteLine(new string('-', 20));
            }

            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                Phone = "123-456-7890",
                Email = "sam@mail.com",
                Address = "123 Main St, City, Country",
                GroupName = "Group A",
                GroupLeader = people[1] as Teacher
            };

            var jack = new Supervisor
            {
                LicenseCode = "SUP12345",
                Phone = "777-777-7777",
                Email = "jack@mail.com",
                Address = "456 Elm St, City, Country"
            };


            var info1 = student as IContactInfo;
            var info2 = jack as IContactInfo;


            MessageSender.SendMessage("Hello, John!", "John", student);

        }
    }
}
