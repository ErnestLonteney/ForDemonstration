namespace YieldExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cats = new CatCollection();
            cats.Add(new Cat { Name = "Fluffy", Description = "A cute cat", Type = "Domestic", Level = 60 });
            cats.Add(new Cat { Name = "Bella", Description = "A playful cat", Type = "Domestic", Level = 40 });
            cats.Add(new Cat { Name = "Max", Description = "A strong cat", Type = "Wild", Level = 70 });
            cats.Add(new Cat { Name = "Businka", Description = "A strong cat", Type = "Wild", Level = 30 });

            foreach (var cat in cats)
            {
                Console.WriteLine($"Name: {cat.Name}, Description: {cat.Description}, Type: {cat.Type}, Level: {cat.Level}");
            }
        }
    }
}
