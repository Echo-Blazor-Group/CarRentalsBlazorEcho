using CarRentalsBlazorEcho.Components;
using CarRentalsBlazorEcho.Data;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace CarRentalsBlazorEcho
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalsBlazor;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
            builder.Services.AddRazorPages();
            
            builder.Services.AddTransient<ICar, CarRepository>();
            builder.Services.AddTransient<ICarCategory, CarCategoryRepository>();
            builder.Services.AddTransient<IOrder, OrderRepository>();
            builder.Services.AddTransient<IUser, UserRepository>();
            builder.Services.AddTransient<ICarPicture, CarPictureRepository>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();

            // Rest of the code
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Rest of the code
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();
            PageActionEndpointConventionBuilder pageActionEndpointConventionBuilder = app.MapRazorPages();
            app.UseAntiforgery();

            app.Run();
        }
    }
}