namespace LINQExamples
{
    internal class Program
    {
        static void Main()
        {
            var emploees = new List<Employee>
            {
                new ()
                {
                    Id = 1,
                    FirstName = "Leo",
                    LastName = "Galante",
                    Salary = 45667,
                    Title = "Software Developer",
                    Email = "leo@mail.com"
                },
                new ()
                {
                    Id = 2,
                    FirstName = "Mary",
                    LastName = "Simons",
                    Salary = 435435,
                    Title = "QA",
                    Email = "mary@mail.com",
                    Phone = "+375434535"
                },
                new ()
                {
                    Id = 3,
                    FirstName = "Kyle",
                    LastName = "Goodson",
                    Salary = 435345,
                    Title = "Software Engeneer",
                    Phone = "+373343434",
                    Email = "kyle@mail.com"
                },
                new ()
                {
                    Id = 4,
                    FirstName = "Dick",
                    LastName = "Peterson",
                    Salary = 45667,
                    Title = "Software Engeneer",
                    Email = "dick@mail.com"
                }
            };

            var bigSallaryEmploees = emploees
                                      .Where(em => em.Salary > 10000)
                                      .OrderBy(em => em.Salary);

            var emailAndPhoneExist = emploees
                                      .Where(em => em.Phone is not null && em.Email is not null)
                                      .OrderBy(em => em.LastName)
                                      .OrderBy(em => em.FirstName);

            

            int howManyHavePhone = emploees.Count(e => e.Phone is not null);
            Console.WriteLine($"How many emploies have phone {howManyHavePhone}");

            Employee? dick = emploees.FirstOrDefault(e => e.FirstName == "Dick" && e.LastName == "Peterson");

            if (dick is not null)
            {
                Console.WriteLine(dick.FirstName);
                Console.WriteLine(dick.LastName);               
            }


            double minSalary = emploees.Min(e => e.Salary);
            double maxSalary = emploees.Max(e => e.Salary);
            double avaregeSalary = emploees.Average(e => e.Salary);
            double sum = emploees.Sum(e => e.Salary);

            Console.WriteLine($"Min salary = {minSalary}");
            Console.WriteLine($"Max salary {maxSalary}");
            Console.WriteLine($"Avarage salary {avaregeSalary}");
            Console.WriteLine($"Sum of all salaries {sum}");

            var grops = emploees.GroupBy(e => e.Title);

            Console.WriteLine(new string('-', 40));

            foreach (var group in grops)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine(new string('-', 10));
                foreach (Employee emp in group)
                {
                    Console.WriteLine(emp.FirstName);
                    Console.WriteLine(emp.LastName);
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 40));

            var titles = emploees.Select(e => e.Title).Distinct().OrderBy(t => t).ToList();
            titles.ForEach(Console.WriteLine);

            Console.WriteLine(new string('-', 40));

            var anonymus = emploees
                           .OrderBy(emp => emp.LastName)
                           .OrderBy(emp => emp.FirstName)
                           .Select(emp => new { Name = emp.FirstName + " " + emp.LastName, emp.Title });

            foreach (var item in anonymus)
            {
                Console.WriteLine($"{item.Name} - {item.Title}");
            }

            var dic = emploees
                     .GroupBy(e => e.Title)
                     .OrderBy(g => g.Key)
                     .ToDictionary(k => k.Key, v => v.Count());

            Console.WriteLine(new string('-', 40));

            foreach (var line in dic)
            {
                Console.WriteLine($"{line.Key} - {line.Value}");
            }

            if (emploees.Any(e => e.Salary < 50000))
            {
                Console.WriteLine("We have someone who needs pay rise");
            }

            if (emploees.All(e => e.Email is not null))
            {
                Console.WriteLine("Every have contact");
            }

            var notValidMails = emploees
                .Select(e => e.Email)
                .Where(email => email?
                .Contains("@") == false);

            if (notValidMails.Any())
            {
                Console.WriteLine("We have some not valid mails");
            }
        }
    }
}
