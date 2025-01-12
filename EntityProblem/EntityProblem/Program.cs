namespace EntityProblem
{
    internal class Program
    {
        static void DisplayInfo<T>(IEntity<T>[] entities)
        {
            for (int i = 0; i < entities.Length; i++)
            {
                Console.WriteLine(entities[i].Id);
                Console.WriteLine(entities[i].Name);
            }
        }

        static void Main(string[] args)
        {
            var emploee1 = new Emploee
            {
                Id = 1,
                Name = "Grag",
                PhoneNumber = "1234567890",
                Position = "Software developer",
                Salary = 2343455.66
            };

            var emploee2 = new Emploee
            {
                Id = 2,
                Name = "Bob",
                PhoneNumber = "1234890",
                Position = "Software developer",
                Salary = 234345.66
            };

            var user1 = new User
            {
                Id = 3,
                Name = "Ann",
                PhoneNumber = "12345890",
                Position = "Manager",
                Salary = 23432434.66,
                Login = "qaz",
                Password = "123445"
            };

            var product1 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Laptop",
                Price = 435.56
            };

            var product2 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Display",
                Price = 345.56
            };

            var document = new Document
            {
                Id = "94535",
                Date = new DateOnly(2024,1,1),
                Body = "Top Secret",
                Name = "Message"
            };


            // IEntity<> data = new IEntity<T>[] { emploee1, emploee2, user1, product1, product2, document };

            var emploies = new IEntity<int>[] { emploee1, emploee2 };
            var products = new IEntity<Guid>[] { product1, product2 };

            DisplayInfo(products);
        }
    }
}
