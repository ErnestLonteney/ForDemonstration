namespace AnimalHyerarhy
{
    class Tiger : WildAnimal
    {
        public Tiger(string name) 
            : base(name)
        {
        }

        public override void MakeVoice()
        {
            Console.WriteLine("ARRRRRRR");
        }
    }
}