namespace LinkedListExample
{
    internal class Program
    {
        static void Main()
        {
            // 1 <--> 2 <--> 3 <--> 4 <--> 5 <--> 6 <--> 7 <--> 8 <--> 9 <--> 10
            var numbers = new LinkedList<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
            
            var current = numbers.First;
            do
            {
                Console.Write(current.Value);
                Console.Write(" ");
                current = current.Next;
            }
            while (current is not null);

            Console.WriteLine();

            current = numbers.Last;
            do
            {
                Console.Write(current.Value);
                Console.Write(" ");
                current = current.Previous;
            }
            while (current is not null);
        }
    }
}
