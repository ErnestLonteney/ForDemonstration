namespace Decorator
{
    internal class Program
    {
        static void Main()
        {
            var employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Title = "Guard",
                PhoneNumber = "123-456-7890"
            };

            employee.SendMail("jane.doe@example.com");

            var policeman = new Policeman()
            {
                BadgeNumber = "12345",
                FirstName = "Mike",
                LastName = "Smith",
                Email = "mike.smith@example.com",
                PhoneNumber = "987-654-3210",
                Title = "Officer"
            };

            // ========== DECORATOR PATTERN DEMO ==========
            // 
            // The Decorator Pattern wraps a component and extends its behavior
            // while maintaining the same interface (Person.Introduce).
            //
            // Step 1: Create a base component (original person)
            // Step 2: Create a decorator instance
            // Step 3: Assign the component to the decorator via WrappedPerson
            // Step 4: Use the decorator — it delegates to the wrapped component then adds its own behavior

            // Example 1: Original component without decoration
            Console.WriteLine("\n=== ORIGINAL PERSON (No Decoration) ===");
            employee.Introduce();

            // Example 2: Same person wrapped with a ProtectiveCostume decorator
            Console.WriteLine("\n=== DECORATED WITH ProtectiveCostume ===");
            var decorated = new ProtectiveCostume();
            decorated.WrappedPerson = employee;
            decorated.Introduce();  // Calls employee.Introduce() then adds "Wearing protective costume."

            // Example 3: Different decorator (WaterCostume) on same component
            Console.WriteLine("\n=== DECORATED WITH WaterCostume ===");
            var waterDecorated = new WaterCostume();
            waterDecorated.WrappedPerson = employee;
            waterDecorated.Introduce();  // Calls employee.Introduce() then adds "Swimming while wearing a water costume."

            // Example 4: Same decorator applied to a different component (policeman)
            Console.WriteLine("\n=== Policeman DECORATED WITH ProtectiveCostume ===");
            var policeDecorated = new ProtectiveCostume();
            policeDecorated.WrappedPerson = policeman;
            policeDecorated.Introduce();  // Calls policeman.Introduce() then adds decoration

            // Example 5: Passing decorated and non-decorated objects to the same method
            // Shows that decorators are transparently used as Person objects
            Console.WriteLine("\n=== POLYMORPHISM: Passing to Greet() Method ===");
            Console.WriteLine("--- Non-decorated employee ---");
            Greet(employee);
            Console.WriteLine("--- Decorated employee (ProtectiveCostume) ---");
            Greet(decorated);
        }

        static void Greet(Person person)
        {
            person.Introduce();
        }
    }
}
