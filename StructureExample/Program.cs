namespace StructureExample
{ 
    internal class Program
    {      
        static void Main()
        {
            Point p1 = new Point(10, 5)
            {
                Name = "Point1"
            };

            var r = p1.Add();

            Point p2 = p1;

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            p2.X = 100;
            p2.Y = 200;

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
