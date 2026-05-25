namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var capitan1 = Capitan.GetCapitan("1", "John", "Doe");
            //Console.WriteLine(capitan1.GetHashCode());


            for (int i = 0; i < 50; i++)
            {
                new Thread(() =>
                {
                    var capitan2 = Capitan.GetCapitan("2", "Jane", "Smith");
                    Console.WriteLine(capitan2.GetHashCode());
                }).Start();
            }

                
            //var capitan3 = Capitan.GetCapitan("3", "Bob", "Johnson");
            //Console.WriteLine(capitan3.GetHashCode());
            //var capitan4 = Capitan.GetCapitan("1", "Mike", "Doe");  
            //Console.WriteLine(capitan4.GetHashCode());
        }
    }
}
