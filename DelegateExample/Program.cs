namespace DelegateExample
{
    internal class Program
    {
        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
                Console.Write($"{array[i]} ");              

            Console.WriteLine();
        }       

        static void Main()
        {
            int[] array = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];

            var res1 = array.Filter(n => (n % 2) == 0);
            var res2 = array.Filter(n => n > 5);
            var res3 = array.Filter(DisplayNegative);


            DisplayArray(res1); 
            DisplayArray(res2); 
            DisplayArray(res3); // Should display nothing
        }

        static bool DisplayNegative(int n)
        {
            return n < 0;
        }
    }
}