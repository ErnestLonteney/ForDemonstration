using Microsoft.AspNetCore.Builder;
using SessionCounter.Infrastructure;
using static System.Net.Mime.MediaTypeNames;

namespace SessionCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            app.Use(async (context, next) =>
            {
                if (context.Session.IsAvailable)
                {
                        context.Session.SetString("SessionId", context.Session.Id);

                        if (!string.IsNullOrEmpty(context.Session.Id) && context.Session.TryGetValue("SessionId", out byte[]? value))
                        {

                            ApplicationState.ActiveSessions[context.Session.Id] = DateTime.Now;

                        }
                }
                
                await next.Invoke();

                ApplicationState.RemoveNotActiveSessions();

            });

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
