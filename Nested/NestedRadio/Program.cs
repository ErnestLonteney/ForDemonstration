namespace NestedRadio
{
    class Program
    {
        static void Main()
        {
            var lamoborginy = new SportCar("Diablo", "Lamborginy", 5.5);
            lamoborginy.AddRadioToCar();
            lamoborginy.AddParktronic();

            lamoborginy.Start();
            lamoborginy.Accelerate(100);
            ((SportCar.SportCarRadio)lamoborginy["Radio"]).TurnOn(); 
        }
    }
}
