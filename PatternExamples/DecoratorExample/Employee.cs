namespace Decorator;

public class Employee : Person
{
    public decimal Salary { get; set; }

    public string Title { get; set; } = string.Empty;


    public void SendMail(string to)
    {
        Console.WriteLine($"Sending mail to {to} from {Email}");
    }
}
