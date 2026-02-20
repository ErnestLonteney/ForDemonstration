namespace NestedRadio
{
    class Program
    {
        static void Main()
        {
            var lamoborginy = new SportCar("Diablo", "Lamborginy", 5.5);
            lamoborginy.AddRadioToCar();
            lamoborginy.AddParktronic();

            Console.WriteLine($"Current speed is {lamoborginy.CurrentSpeed}");
            lamoborginy.Start();
            lamoborginy.Accelerate(100, 15);

            Console.WriteLine($"Current speed is {lamoborginy.CurrentSpeed}");

            lamoborginy.Decelerate(40);
            lamoborginy.Decelerate(20);

            Console.WriteLine($"Current speed is {lamoborginy.CurrentSpeed}");

            lamoborginy.Stop();

            Console.WriteLine($"Current speed is {lamoborginy.CurrentSpeed}");
        }
    }
}
