namespace BridgeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var benzinEngine1 = new GasolineEngine("V8")
            {
                Power = 400
            };

            var benzinEngine2 = new GasolineEngine("V6")
            {
                Power = 300,
            };

            var diselEngine1 = new DieselEngine("GH-56")
            {
                Power = 470
            };


            var car1 = new Sedan("1232133213213", benzinEngine1)
            {
                Make = "BMW",
                Model = "X5",
            };

            var car2 = new Sedan("213321323", benzinEngine2)
            {
                Make = "BMW",
                Model = "X5",
            };

            var car3 = new Sedan("345454534", diselEngine1)
            {
                Make = "BMW",
                Model = "X5",
            };

            var car4 = new Crossover("12232334", diselEngine1)
            {
                Make = "BMW",
                Model = "F56",
            };

            var car5 = new Crossover("12232334", benzinEngine1)
            {
                Make = "Mercedes",
                Model = "GLA",
            };

            var cars = new List<Car> { car1, car2, car3, car4, car5 };

            foreach (var car in cars)
            {
                Console.WriteLine($"Car: {car.Make} {car.Model}");
                car.Start();
                Console.WriteLine(new String('-', 50));
                Console.WriteLine();
            }
        }
    }
}
