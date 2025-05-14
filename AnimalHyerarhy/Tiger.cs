namespace AnimalHyerarhy
{
    class Tiger : WildAnimal
    {
        public Tiger(string name) 
            : base(name)
        {
        }

        public override void Hunt()
        {
            Console.WriteLine("Finding antilopa...");
        }

        public override void MakeVoice()
        {
            Console.WriteLine("Hrrr");
        }
    }
}