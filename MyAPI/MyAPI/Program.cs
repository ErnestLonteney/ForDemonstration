
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;
using MyAPI.Services;
using MyAPI.Services.Interfaces;

namespace MyAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Fixed the issue by using builder.Configuration to access the connection string
            string connectionString = builder.Configuration.GetConnectionString("MainConnection") ?? throw new ArgumentException("Connection string is missing");
            builder.Services.AddDbContext<ProductStoreContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddScoped<IProductService, ProductService>();

            var app = builder.Build();

            app.Map("/", () => "My API");

            app.MapControllers();

            app.Run();
        }
    }
}
