namespace NullRefExceptionHandling
{
    internal class Program
    {
        static void DisplayInfo(Person? person)
        {
            if (person != null)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.BirthDay);
            }
        }

        static void Main(string[] args)
        {
            Person? person = new Person()
            {
                FirstName = "John",
                LastName = "Doe"              
            };

            Console.WriteLine(person.FirstName.Concat(person.LastName ?? string.Empty));

            DisplayInfo(person);
        }
    }
}
