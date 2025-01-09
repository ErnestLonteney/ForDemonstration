namespace ConsoleApp1
{
    internal class Program
    {
        static string GetInfo(in Point point)
        {
            return $"X={point.X} Y={point.Y}";
        }

        static void Main(string[] args)
        {
            //Point point = new(10, 10);

            //Point point2;

            //point2 = point;

            //Console.WriteLine(point2.X);
            //Console.WriteLine(point2.Y);

            //point2.X = 100;
            //point2.Y = 200;

            //Console.WriteLine(point.X);
            //Console.WriteLine(point.Y);

            //string result = GetInfo(point2);

            //Console.WriteLine(result);  

            //MyDouble a = new MyDouble(12,45);
            //Console.WriteLine(a.Value);


            var backet1 = new Factory().GetVolume(15.67);
            var backet2 = new Volume { Value = 67.8 };
            var backet3 = 
        }
    }
}
