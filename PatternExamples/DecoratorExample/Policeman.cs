namespace Decorator;

public class Policeman : Employee
{
    public string BadgeNumber { get; set; }

    public void Arrest()
    {
        Console.WriteLine($"{FirstName} {LastName} is arresting");
    }
}
