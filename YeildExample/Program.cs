using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YeildExample
{
    internal class Program
    {
        static void DisplayNambers(IEnumerable<int> input)
        {
            foreach (int i in input)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
            }

            Console.ResetColor();
        }


        public static IEnumerable<int> GetPairedNumbers(IEnumerable<int> array)
        {
            if (array.First() > 10)
                yield break;


            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = [12, 34, 23, 67, 55, 90, 100, 117];

            //List<int> list = new List<int>();

            //foreach (int i in array)
            //{
            //    if (i % 2 == 0)
            //    {
            //        list.Add(i);
            //    }
            //}

            var filtered = GetPairedNumbers(array);
            DisplayNambers(filtered);
        }

    }
}
