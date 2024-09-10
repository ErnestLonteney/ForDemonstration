using BasicSorts;

namespace ConsoleApp9
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            var array = new[] { 25, -1, 90, 78, 100, 11 };

            SortingManager.InsertingSort(array);

            foreach (var item in array)
                Console.Write(item + " ");  
        }
    }
}
