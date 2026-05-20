namespace PrototypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carSimple = new CarPrototype()
            {
                CarType = "Simple",
                Mark = "Toyota",
                Model = "Camry"
            };

            var carExtended2 = carSimple.Clone();
            carExtended2.CarType = "Extended"; 
            
            var carExtended3 = carExtended2.Clone();
            carExtended3.CarType = "SuperExtended";
          

            Console.WriteLine($"Car 1: {carSimple.CarType}, {carSimple.Mark}, {carSimple.Model}");
            Console.WriteLine($"Car 2: {carExtended2.CarType}, {carExtended2.Mark}, {carExtended2.Model}");
            Console.WriteLine($"Car 3: {carExtended3.CarType}, {carExtended3.Mark}, {carExtended3.Model}");

        }
    }
}
