using EFSampleOne.Entities;

namespace EFSampleOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDatabase = new ShopDbContext();          

            //var newProduct = new Product
            //{
            //    Name = "Printer",
            //    Code = "12345678",
            //    Price = 156.78m
            //};

            //myDatabase.Products.Add(newProduct);    

            //myDatabase.SaveChanges();

            foreach (Product product in myDatabase.Products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(new String('-', 40));
            }

            foreach (VTopSell sell in myDatabase.VTopSells)
            {
                Console.WriteLine(sell.Name);
                Console.WriteLine(sell.TotalCount);
            }


            var printer = myDatabase.Products.SingleOrDefault(p => p.Name == "Printer");

            if (printer is not null)
            {
                printer.Price = 100.00m;
            }

            myDatabase.SaveChanges();
        }
    }
}
