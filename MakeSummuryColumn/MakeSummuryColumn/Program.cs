using System.Reflection;

namespace MakeSummuryColumn
{
    internal class Program
    {
        static AvaragePrice[] GetPrices(Prices[] prices)
        {
            var result = new List<AvaragePrice>();
            Type pt = prices[0].GetType();

            for (int i = 0; i< prices.Length; i++)
            {           
               var box = new List<double>();

                foreach (PropertyInfo pi in pt.GetProperties())
                {
                    if (pi.PropertyType != typeof(Double))
                        continue;

                    object? value = pi.GetValue(prices[i]);
                    if (value is not null)
                        box.Add((double)value);
                }

                result.Add(new AvaragePrice()
                {
                    ProductId = prices[i].ProductId,
                    Price = box.Average()
                });
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            Prices[] pricesSet =
            [
                new Prices
                {
                    ProductId = 1,
                    LandedPrice = 234,
                    MedianPrice = 345,
                    PurchasePrice = 340,
                    RawPrice = 200
                },
                new Prices
                {
                    ProductId = 1,
                    LandedPrice = 234,
                    MedianPrice = 325,
                    PurchasePrice = 320,
                    RawPrice = 190,
                },
                new Prices
                {
                    ProductId = 3,
                    LandedPrice = 456,
                    MedianPrice = 345,
                    PurchasePrice = 495,
                    RawPrice = 300
                }
            ];     
            
            var avaragePrices = GetPrices(pricesSet);
            
            foreach (var p in avaragePrices)
                Console.WriteLine(p.Price); 

        }
    }
}
