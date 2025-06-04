using Database.Entities;
using Microsoft.EntityFrameworkCore;
using MyAPI.Services.Interfaces;
using MyAPI.Services;
using MyAPI.Models;

namespace MyAPI.minimal;

public class Program
{
    public static void Main(string[] args)
    {       
        var builder = WebApplication.CreateBuilder(args);

        string connectionString = builder.Configuration.GetConnectionString("MainConnection") ?? throw new ArgumentException("Connection string is missing");
        builder.Services.AddDbContext<ProductStoreContext>(options => options.UseSqlServer(connectionString));
        builder.Services.AddScoped<IProductService, ProductService>();

        var app = builder.Build();

        app.Map("/", () => "My API");

        app.MapGet("api/product/list", (IProductService productService) =>
        {
            var result = productService.GetProducts();

            return (result is not null) ? Results.Ok(result) : Results.BadRequest();
        });

        app.MapGet("api/product/{productId}", (IProductService productService, int productId) =>
        {
            var product = productService.GetProduct(productId);
            return (product is not null) ? Results.Ok(product) : Results.BadRequest();
        });

        app.MapPost("api/product/create", (IProductService productService, ProductModel product) =>
        {
            bool result = productService.CreateProduct(product);
            return (result) ? Results.Ok(product) : Results.BadRequest();
        });

        app.MapPut("api/product/update", (IProductService productService, ProductModel product) =>
        {
            productService.UpdateProduct(product);
            return Results.Ok(product);
        });

        app.MapDelete("api/product/{productId}", (IProductService productService, int productId) =>
        {
            productService.DeleteProduct(productId);
            return Results.Ok();
        });

        app.Run();
    }
}
