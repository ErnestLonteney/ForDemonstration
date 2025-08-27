using System.Text;

namespace EmploeeTypes
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            var customer1 = new Customer("Shevchenko", "Hanna", "2343344556")
            {
                Email = "hanna@mail.com",
                Phone = "+380988765432",
                Type = CustomerType.Szo,
                DateOfBirth = new DateTime(2001, 12, 1)
            };

            var customer2 = new Customer("Davydenko", "Maksym", "2343344545")
            {
                Email = "maksym@mail.com",
                Phone = "+380688765432",
                Type = CustomerType.Fiz,
                DateOfBirth = new DateTime(2000, 11, 10)
            };

            var customer3 = new Customer("Shevchenko", "Mykola", "2349944556")
            {
                Email = "mykola@mail.com",
                Phone = "+380988765476",
                Type = CustomerType.Fop,
                DateOfBirth = new DateTime(1964, 11, 11)
            };


            //  CustomerType vip = (CustomerType)Enum.Parse(typeof(CustomerType), "VIP");

            string[] names = Enum.GetNames(typeof(CustomerType));

            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);

            int type = (int)customer3.Type;

            Customer[] customers = [ customer1, customer2, customer3 ];

            for (int i = 0; i < customers.Length; i++)
            {
                switch (customers[i].Type)
                {
                    case CustomerType.Fiz: Console.WriteLine(customers[i].Phone);
                        break;
                    case CustomerType.Fop: Console.WriteLine(customers[i].Email);
                        break;
                    case CustomerType.Szo: Console.WriteLine(customers[i].Address);
                        break;
                }


                Console.WriteLine($"Рік народження = {customers[i].DateOfBirth.Year}");
                Console.WriteLine($"Повних років = {DateTime.Today.Year - customers[i].DateOfBirth.Year}");
            }


            DateTime newYear = new DateTime(2026, 1, 1);
            TimeSpan daysToNewYear = newYear - DateTime.Today;

            Console.WriteLine($"До Нового року залишилось {daysToNewYear.TotalDays} днів");

            Console.WriteLine(DateTime.Now);
        }
    }
}
