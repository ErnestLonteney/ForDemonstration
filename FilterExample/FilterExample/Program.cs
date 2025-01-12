using System.Xml.Linq;

namespace FilterExample
{
    delegate bool FilterDelegate(int number);

    internal class Program
    {
        static int[] Filter(int[] array, FilterDelegate filterType)
        {
            var result = new List<int>(); 

            for (int i = 0; i < array.Length; i++)
            {
               if (filterType.Invoke(array[i]))
                    result.Add(array[i]);
            }

            return result.ToArray();
        }

        static void Main()
        {
            int[] numbers = [12, 344, 56, 76, 0, -34, 345];


            var filtered = Filter(numbers, (element) => element % 2 == 0);

            for (int i = 0; i < filtered.Length; i++)
            {
                Console.WriteLine(filtered[i]);  
            }

            var filtered2 = Filter(numbers, (element) => element > 0);

            for (int i = 0; i < filtered2.Length; i++)
            {
                Console.WriteLine(filtered2[i]);
            }
        }
    }
}
