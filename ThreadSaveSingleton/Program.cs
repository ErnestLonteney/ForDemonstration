namespace ThreadSaveSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                new Thread(() =>
                {
                    var singleton = Singleton.GetInstance(i);
                    Console.WriteLine(singleton.GetHashCode());
                })
                .Start();
            }


            var singleton1 = Singleton.GetInstance(1);
            Console.WriteLine(singleton1.GetHashCode());
            var singleton2 = Singleton.GetInstance(2);
            Console.WriteLine(singleton2.GetHashCode());
            var singleton3 = Singleton.GetInstance(3);
            Console.WriteLine(singleton3.GetHashCode());

        }
    }
}
