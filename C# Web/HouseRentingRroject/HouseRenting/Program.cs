using HouseRenting.Contracts;
using HouseRenting.Data;
using HouseRenting.Data.Models;
using HouseRenting.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HouseRenting.Infrastructure;

namespace HouseRenting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<HouseRentingDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<HouseRentingDbContext>();

            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            // Update to Scoped
            builder.Services.AddScoped<IHouseService, HouseService>();
            builder.Services.AddScoped<IAgentService, AgentService>();
            builder.Services.AddTransient<IStatisticsService, StatisticsService>();
            builder.Services.AddTransient<IApplicationUserService, ApplicationUserService>();
            
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // For handling 500 errors
                app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}"); // For handling other status codes
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "House Details",
                    pattern: "/House/Details/{id}/{information}",
                    defaults: new { Controller = "House", Action = "Details" }
                    );

                app.MapDefaultControllerRoute();
                app.MapRazorPages();
            });

            app.SeedAdmin();

            app.Run();
        }
    }
}
