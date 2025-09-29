namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Emploee(1, "John", "Doe");

            var employee2 = new Emploee(2, "Jane", "Smith");

            var employee3 = new Emploee();


            employee1.Head = employee2;

            employee1.ReportIsseu();
            employee2.ReportIsseu();
        }
    }
}
