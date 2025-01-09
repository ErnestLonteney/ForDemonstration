namespace ConsoleApp2
{
    internal class Program
    {
        static void Greatings(int count, string text = "Nice to meet you in our team")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }
        }
        
        static void Greatings(string count, string text = "Nice to meet you in our team")
        {
            int parsedCount = (count.ToLower()) switch 
            {
                "one" => 1,     
                "two" => 2,
                "three" => 3,
                "four" => 4,
                "five" => 5,
                _ => 0         
            };

            Greatings(parsedCount, text);
        }

        static void Main()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            Console.WriteLine("Input count");
            string count = Console.ReadLine();

            if (count != null)
            {
                bool isNumber = int.TryParse(count, out int parsedCount);

                if (isNumber)
                {
                    if (string.IsNullOrEmpty(text))
                    {
                        Greatings(parsedCount);
                    }
                    else
                        Greatings(parsedCount, text);
                }
                else
                {

                    if (text == null)
                        Greatings(count);
                    else
                        Greatings(count, text);
                }
            }            
        }
    }
}
