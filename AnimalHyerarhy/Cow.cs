namespace AnimalHyerarhy
{
    class Cow : DomesticAnimal
    {
        public Cow(string name) 
            : base(name)
        {
        }

        public override void Depasture()
        {
            Console.WriteLine("Eat grase");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("Mu-mu");
        }
    }
}
