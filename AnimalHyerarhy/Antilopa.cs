namespace AnimalHyerarhy
{
    class Antilopa : WildAnimal
    {
        public Antilopa(string name) 
            : base(name)
        {
        }

        public override void MakeVoice()
        {
            Console.WriteLine("IGOGO");
        }
    }
}