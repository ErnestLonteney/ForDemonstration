namespace InterfaceExample
{
    internal class Program
    {
        static void Main()
        {
            var person = new Person
            {
                Name = "John",
                Salary = 50000
            };  

            IAdditionalFunctionallity additionalFunctionality = person;

            additionalFunctionality.Greet(person.Name);
        }
    }
}
