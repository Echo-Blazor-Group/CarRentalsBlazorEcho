using CarRentalsBlazorEcho.Components;
using CarRentalsBlazorEcho.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

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

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.Name = "auth_token";
                    options.LoginPath = "/Login";
                    options.LogoutPath = "/Logout";
                    options.Cookie.MaxAge = TimeSpan.FromMinutes(15);
                    options.AccessDeniedPath = "/AccessDenied";
                });
            builder.Services.AddAuthentication();
            builder.Services.AddCascadingAuthenticationState();


            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalsBlazor;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

           
            builder.Services.AddTransient<ICar, CarRepository>();
            builder.Services.AddTransient<ICarCategory, CarCategoryRepository>();
            builder.Services.AddTransient<IOrder, OrderRepository>();
            builder.Services.AddTransient<IUser, UserRepository>();


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
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}