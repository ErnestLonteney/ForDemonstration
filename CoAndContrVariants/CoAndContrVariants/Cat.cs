namespace CoAndContrVariants;

class Cat : Animal
{
    public Cat()
    {
    }
    public Cat(string name)
    {
        Name = name;
        Kind = "Cats";
    }

    public override void MakeVoice()
    {
        Console.WriteLine("Myau");
    }
}
