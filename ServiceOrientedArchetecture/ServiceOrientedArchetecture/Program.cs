using DataAccess;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services;
using Services.Interfaces;

namespace ServiceOrientedArchetecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            string conectionString = "Server=";
            builder.Services.AddDbContext<MarketContext>(options => options.UseSqlServer(conectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
