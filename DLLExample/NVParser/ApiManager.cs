using System.Text;
using System.Text.Json;

namespace NVParser
{
    internal static class ApiManager
    {
        const string Url = "https://api.novaposhta.ua/v2.0/json/";
        const string ApiKey = "bc1fb643db43517a578270e0c92be226";

        public static async Task<List<City>> SendToNPAsync()
        {
            using var client = new HttpClient();

            var body = new
            {
                apiKey = ApiKey,
                modelName = "Address",
                calledMethod = "getCities",
                methodProperties = new object()
            };

            string bodySting = JsonSerializer.Serialize(body);

            var content = new StringContent(bodySting, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(Url, content);

            var result = await response.Content.ReadAsStringAsync();

            var res = JsonSerializer.Deserialize<Cities>(result);

            return res?.Data?.ToList() ?? [];
        }

        public static async Task<List<Warehouse>> GetWarehousesByCityRef(string cityRef)
        {
            using var client = new HttpClient();

            var body = new
            {
                apiKey = ApiKey,
                modelName = "Address",
                calledMethod = "getWarehouses",
                methodProperties = new { CityRef = cityRef },
                TypeOfWarehouseRef = "9a68df70-0267-42a8-bb5c-37f427e36ee4"
            };

            string bodySting = JsonSerializer.Serialize(body);
            var content = new StringContent(bodySting, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(Url, content);

            var result = await response.Content.ReadAsStringAsync();
            var res = JsonSerializer.Deserialize<Warehouses>(result);

            return res?.Success ?? false ? res.Data.ToList() : [];
        }
    }
}
