namespace Decorator;

public abstract class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;


    public string? Email { get; set; }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hi, my name is {FirstName} {LastName}. You can reach me at {Email} or {PhoneNumber}");
    }


}
