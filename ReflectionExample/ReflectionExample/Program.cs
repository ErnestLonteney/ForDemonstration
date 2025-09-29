using System.Reflection;

namespace ReflectionExample
{
    internal class Program
    {
        static (decimal, decimal, decimal) CountPrices(object price)
        {
            decimal sum = 0;         
            Type type = price.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            decimal minValue = (decimal)properties[0].GetValue(price);
            decimal maxValue = (decimal)properties[0].GetValue(price);

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(decimal))
                {
                    decimal value = (decimal)property.GetValue(price);  
                    if (value < minValue) 
                        minValue = value;
                    if (value > maxValue)
                        maxValue = value;
                    
                    sum += value; 
                }
            }

            return (sum / properties.Length, minValue, maxValue);
        }

        static (decimal avaragePrice, decimal minPrice, decimal maxPrice) CountPrices(Price price)
        {
            List<decimal> values = [price.RawPrice, price.LandedPrice, price.DeliveryPrice, price.StorePrice];

            return (
            values.Average(),
            values.Min(),
            values.Max());
        }

        static void Main(string[] args)
        {
            var price1 = new Price
            {
                DeliveryPrice = 5.0m,
                LandedPrice = 15.0m,
                RawPrice = 10.0m,
                StorePrice = 12.0m
            };
            
            var price2 = new Price
            {
                DeliveryPrice = 5.0m,
                LandedPrice = 15.0m,
                RawPrice = 10.0m,
                StorePrice = 12.0m
            };

            var priceProduct = new ProductPrice
            {
                PriceInMainStore = 12.0m,
                PriceWithDiscount = 9.0m,
                StoragePrice = 11.0m
            };


            var res1 = CountPrices(price1);
            Console.WriteLine($"av={res1.avaragePrice}, min={res1.minPrice} max={res1.maxPrice}");

            var res2 = CountPrices(price2);
            Console.WriteLine($"av={res2.avaragePrice}, min={res2.minPrice} max={res2.maxPrice}");

            (decimal, decimal, decimal) result = CountPrices(priceProduct);
            Console.WriteLine($"av={result.Item1}, min={result.Item2} max={result.Item3}");


        }
    }
}
