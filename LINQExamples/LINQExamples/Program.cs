using System.Linq;

namespace LINQExamples
{
    internal class Program
    {
        static void Main()
        {
            var emploees = new List<Employee>
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Leo",
                    LastName = "Galante",
                    Salary = 45667,
                    Title = "Software Developer",
                    Email = "leo@mail.com"
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Mary",
                    LastName = "Simons",
                    Salary = 435435,
                    Title = "QA",
                    Email = "mary@mail.com",
                    Phone = "+375434535"
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Kyle",
                    LastName = "Goodson",
                    Salary = 435345,
                    Title = "Software Engeneer",
                    Phone = "+373343434",
                    Email = "kyle@mail.com"
                },
                new Employee()
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
                                      .Where(em => em.Salary > 50000)
                                      .OrderBy(em => em.Salary);


            //foreach (var employee in bigSallaryEmploees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Salary}");
            //}

            var emailAndPhoneExist = emploees
                                      .Where(em => em.Phone is not null && em.Email is not null)
                                      .OrderBy(em => em.LastName)
                                      .ThenBy(em => em.FirstName);

            foreach (var employee in emailAndPhoneExist)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Salary}");
            }


            var newQuery = emploees.Where(em => em.Title == "Software Engeneer")
                                   .OrderBy(em => em.FirstName)
                                   .Select(em => new { FullName = em.FirstName + " " + em.LastName, em.Salary });


            int howManyHavePhone = emploees.Count(e => e.Phone is not null);
            Console.WriteLine($"How many emploies have phone {howManyHavePhone}");

            Employee? dick = emploees.FirstOrDefault(e => e.FirstName == "Dick" && e.LastName == "Peterson");

            if (dick is not null)
            {
                Console.WriteLine(dick.Phone);
                Console.WriteLine(dick.Email);
            }


            double minSalary = emploees.Min(e => e.Salary);
            double maxSalary = emploees.Max(e => e.Salary);
            double avaregeSalary = emploees.Average(e => e.Salary);
            double sum = emploees.Sum(e => e.Salary);

            Console.WriteLine($"Min salary = {minSalary}");
            Console.WriteLine($"Max salary {maxSalary}");
            Console.WriteLine($"Avarage salary {avaregeSalary}");
            Console.WriteLine($"Sum of all salaries {sum}");

            var groups = emploees.GroupBy(e => e.Title);

            Console.WriteLine(new string('-', 40));

            foreach (var group in groups)
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

            var groppedEmployees = from employee in emploees
                                   group employee by employee.Title;

            Console.WriteLine(new string('-', 40));

            List<string> titles = emploees.Select(e => e.Title).Distinct().OrderBy(t => t).ToList();
            titles.ForEach(Console.WriteLine);

            Console.WriteLine(new string('-', 40));

            Dictionary<string, int> dic = emploees
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
                .Where(email => email?.Contains("@") == false);

            if (notValidMails.Any())
            {
                Console.WriteLine("We have some not valid mails");
            }

            var topTwoEmployees = emploees.Take(2).ToList();

            foreach (var employee in topTwoEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }

            var twoAfterOneEmployees = emploees.Skip(1).Take(2);

            foreach (var employee in twoAfterOneEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
