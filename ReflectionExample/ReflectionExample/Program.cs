using System.Reflection;

namespace ReflectionExample
{
    internal class Program
    {
        decimal SumOfAllPrices(ShopPrice price)
        {
            decimal sum = 0;

            sum += price.RawPrice;
            sum += price.LandedPrice;
            sum += price.StoragePrice;
            sum += price.DeliveryPrice;
           
            return sum;

        }

        static (decimal avaragePrice, decimal minPrice, decimal maxPrice) CountPrices(Price price)
        {
           
            Type type = price.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            decimal sum = 0;
            decimal minValue = (decimal)properties[0].GetValue(price);
            decimal maxValue = (decimal)properties[0].GetValue(price);

            int i = 0;
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(decimal))
                {
                    i++;
                    decimal value = (decimal)property.GetValue(price);  

                    if (value == 0) continue;

                    if (value < minValue) 
                        minValue = value;
                    if (value > maxValue)
                        maxValue = value;
                    
                    sum += value; 
                }
            }

            return (sum / i, minValue, maxValue);
        }

        static (decimal avaragePrice, decimal minPrice, decimal maxPrice) CountPrices2(Price price)
        {
            if (price is ShopPrice shopPrice)
            {
                List<decimal> values = [shopPrice.RawPrice, shopPrice.LandedPrice, shopPrice.StoragePrice, shopPrice.DeliveryPrice];
                return (
                    values.Average(),
                    values.Min(),
                    values.Max());
            }
            else
            {
                List<decimal> values = [price.RawPrice, price.LandedPrice, price.StoragePrice];
                return (
                    values.Average(),
                    values.Min(),
                    values.Max());
            }
        }

        static void Main(string[] args)
        {
            var price1 = new Price
            {
                LandedPrice = 15.0m,
                RawPrice = 10.0m,
                StoragePrice = 12.0m
            };
            
            var price2 = new ShopPrice
            {
                DeliveryPrice = 5.0m,
                LandedPrice = 15.0m,
                RawPrice = 10.0m,
                StoragePrice = 12.0m
            };

            var priceProduct = new ProductPrice
            {
                PriceWithLoyality = 12.0m,
                PriceWithDiscount = 9.0m,
                NettoPrice = 11.0m,
                PriceWithTax = 13.0m,
            };


            var res1 = CountPrices(price1);
            Console.WriteLine($"av={res1.avaragePrice}, min={res1.minPrice} max={res1.maxPrice}");

            var res2 = CountPrices(price2);
            Console.WriteLine($"av={res2.avaragePrice}, min={res2.minPrice} max={res2.maxPrice}");

            var result = CountPrices(priceProduct);
            Console.WriteLine($"av={result.avaragePrice}, min={result.minPrice} max={result.maxPrice}");


        }
    }
}
