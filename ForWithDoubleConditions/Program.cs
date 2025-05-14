namespace ForWithDoubleConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0, j = 0; i + j < 10; i += 2, j++)
            //{
            //    Console.WriteLine($"i: {i}, j: {j}");
            //    // The loop will continue until i + j is less than 10
            //    // i will increment by 2 and j will increment by 1 in each iteration
            //}

            //for (int i = 0; i < 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            for (string i = "0"; i != "00000"; i += "0" )
            {
                Console.WriteLine(i);
            }
        }
    }
}
