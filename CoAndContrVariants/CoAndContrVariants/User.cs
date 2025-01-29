namespace CoAndContrVariants;

class User<T, R> : IFactory<T, R> where T : new()
{
    public User()
    {
        Method(Login);     
    }

    public string Login { get; set; } = string.Empty;
    public string? Password { get; set; }

    public string GetInfo(R obj)
    {
        return obj.GetType().Name;
    }

    public T GetInstance()
    {
        return new T(); 
    }

    private void Method(string? value) => Console.WriteLine(value?.ToUpper());
}
