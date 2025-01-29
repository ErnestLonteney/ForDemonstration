namespace LINQExamples;

class Employee
{
    public int Id { get; init; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public double Salary { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

}
