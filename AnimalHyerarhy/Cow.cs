namespace AnimalHyerarhy
{
    class Cow : DomesticAnimal
    {
        public Cow(string name) 
            : base(name)
        {
        }

        public override void MakeVoice()
        {
            Console.WriteLine("MYYYY");
        }
    }
}
