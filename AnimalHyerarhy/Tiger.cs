namespace AnimalHyerarhy
{
    class Tiger : Predator
    {
        public Tiger(string name) 
            : base(name)
        {
        }

        public override void Hunt()
        {
           Console.WriteLine($"{Name} is hunting");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("ARRRRRRR");
        }
    }
}