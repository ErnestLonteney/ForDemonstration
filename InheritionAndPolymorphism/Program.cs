namespace InheritionAndPolymorphism
{
    internal class Program
    {
        static void Main()
        {
           var employee = new Employee("John", "Doe", "Software Engineer", "123456789", 50000);
          //  employee.IntroduceMyself();
           // employee.inn = "123456789"; // Accessing the protected field 'inn' from the Employee class
            employee.SendReport("Project A");
            
            var manager = new Manager("Jane", "Smith", "Project Manager", 80000, "987654321", "IT");
          //  manager.IntroduceMyself();
            manager.HireEmployee(employee);

            Employee employee1 = manager; // Upcast 
            Manager manager1 = (Manager)employee1; // Downcast

            if (employee1 is Manager manager3)
            {
                Console.WriteLine(manager3.Department);
            }

            Manager? manager2 = employee1 as Manager; // Downcast using 'as' operator
            if (manager2 is not null)
            {
                Console.WriteLine(manager2.Department);
            }

            Person person1 = manager;

            Employee employee3 = (Employee)person1;

            var vipClient = new VIPClient("Alice", "Johnson", "DE12345678901234567890", "VIP123")
            {
                IBAN = "DE12345678901234567890",
            };
            vipClient.IntroduceMyself();



            var client = new Client("Bob", "Smith", "DE09876543210987654321")
            {
                IBAN = "DE09876543210987654321"
            };


            Employee[] employees = [ employee, manager ];

            foreach (var emp in employees)
            {
                Console.WriteLine(new String('-', 20));
                emp.SendReport("Monthly Report");
                Console.WriteLine(new String('-', 20));

            }
        }
    }
}
