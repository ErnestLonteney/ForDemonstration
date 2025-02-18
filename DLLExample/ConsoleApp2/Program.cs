namespace ConsoleApp2
{

    interface IVoice
    {
        void Say();
    }

    class Cat : IVoice
    {
        public void Say()
        {
            Console.WriteLine("Myau");
        }
    }

    class Dog : IVoice
    {
        public void Say()
        {
            Console.WriteLine("Gau");
        }

    }

    internal class Program
    {
        static void Main()
        {
            var cat1 = new Cat();   
            var cat2 = new Dog();

            IVoice[] animals = [ cat1, cat2 ];

            for (int i = 0; i< animals.Length; i++)
                animals[i].Say();
        }
    }
}
