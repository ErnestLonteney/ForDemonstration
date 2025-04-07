namespace AnimalHyerarhy
{
    class Antilopa : Herbivore
    {
        public Antilopa(string name) 
            : base(name)
        {
        }

        public override void Herd()
        {
             Console.WriteLine($"{Name} is herding");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("IGOGO");
        }
    }
}