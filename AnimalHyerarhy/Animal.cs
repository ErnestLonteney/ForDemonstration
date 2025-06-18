namespace AnimalHyerarhy
{
    abstract class Animal
    {
        protected Animal(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int CountPaws { get; init; }

        public abstract void MakeVoice();

        public void IntroduseMyselfe()
        {
            Console.WriteLine($"Hello my name is {Name}");
            MakeVoice();
        }
    }
}
