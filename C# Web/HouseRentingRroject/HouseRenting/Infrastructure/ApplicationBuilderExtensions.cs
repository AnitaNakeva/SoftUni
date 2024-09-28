using HouseRenting.Data.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static HouseRenting.Data.DataConstants.AdminUser;

namespace HouseRenting.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(AdminRoleName))
                {
                    return;
                }

                var role = new IdentityRole { Name = AdminRoleName };

                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByNameAsync(AdminEmail);

                Console.WriteLine("didko e sladuk " + admin.Email);

                await userManager.AddToRoleAsync(admin, role.Name);
            })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}
