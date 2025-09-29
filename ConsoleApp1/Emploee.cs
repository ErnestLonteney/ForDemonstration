namespace ConsoleApp1;

 class Emploee
{
    private readonly int id = -1;

    public string Name { get; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }     
    public decimal Salary { get; set; }

    public Emploee Head { get; set; }

    public Emploee(int id, string name, string surname)
    {
        this.id = id;
        Name = name;
        Surname = surname;         
    }

    public Emploee()
    {
            
    }

    public void ReportIsseu()
    {
        Console.WriteLine("Issue with moving window");
        Console.WriteLine($"Name={Name} Surname={Surname}");

        if (Head != null)
            Console.WriteLine($"My head is {Head.Surname} {Head.Name}");
    }

}
