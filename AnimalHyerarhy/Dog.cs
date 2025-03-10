

namespace AnimalHyerarhy
{
    class Dog : HomeAnimal
    {
        public Dog(string name) 
            : base(name)
        {
        }

        public override void MakeVoice()
        {
            Console.WriteLine("Wou-Wou");
        }

        public override void Play()
        {
            Console.WriteLine("Play with bone");
        }

        public void Protect()
        {
            Console.WriteLine("The dog in protecting mode");
        }
    }
}
