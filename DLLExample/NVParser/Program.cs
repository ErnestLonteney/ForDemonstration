using System.Text;
using System.Text.Json;

namespace NVParser
{
    internal class Program
    {
        static async Task Main()
        {
           Console.OutputEncoding = Encoding.UTF8;

            OldWarhouses oldwarehouses = new();
           var cities = await ApiManager.SendToNPAsync();

            await Parallel.ForEachAsync(cities, async (city, canceletionToken) =>
            {              
                var warehouses = await ApiManager.GetWarehousesByCityRef(city.Ref);

                foreach (var warehouse in warehouses)
                {
                    oldwarehouses.Response.Add(new()
                    {
                        city_ref = city.Ref,
                        city_id = city.CityID,
                        city = city.Description,
                        cityRu = city.DescriptionRu,
                        Ref = warehouse.Ref,
                        address = warehouse.Description,
                        addressRu = warehouse.DescriptionRu,
                        number = warehouse.Number,
                        wareId = warehouse.SiteKey,
                        phone = warehouse.Phone,
                        max_weight_allowed = warehouse.PlaceMaxWeightAllowed
                    });

                    Console.WriteLine($"{city.Description} has been added");
                }
            });

            string json = JsonSerializer.Serialize(oldwarehouses);
            await File.WriteAllTextAsync("np.json", json);

            Console.WriteLine($"Total count {oldwarehouses.Response.Count}");
        }
    }
}
