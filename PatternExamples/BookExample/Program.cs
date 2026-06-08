namespace BookExample
{
    internal class Program
    {
        private static void ReadBook(Book book)
        {
            foreach (Page p in book)
            {
                Console.WriteLine($"Number - {p.Number}");
                Console.WriteLine($"Text - {p.Text}");
   
            }
        }


        static void Main(string[] args)
        {
            var p1 = new Page(1) { Text = "Page 1 content" };
            var p2 = new Page(2) { Text = "Page 2 content" };
            var p3 = new Page(3) { Text = "Page 3 content" };

            var b1 = new Book(p1, p2, p3)
            {
                Author = "John Doe",
                Title = "C# 14.0 in Depth",
                Description = "A comprehensive guide to C# 14.0 features."
            };

            ReadBook(b1);
            ReadBook(b1);

            while 
        }
    }
}
