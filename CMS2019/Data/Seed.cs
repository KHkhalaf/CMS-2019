using CMS2019.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS2019.Data
{
    public static class Seed
    {
        public static async Task CreateRoles(IServiceProvider serviceProvider, IConfiguration Configuration)
        {

            var scopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
            var scope = scopeFactory.CreateScope();

            //adding customs roles
            var RoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Manager", "Member" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                // creating the roles and seeding them to the database
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // creating a super user who could maintain the web app
            var poweruser = new ApplicationUser
            {
                UserName = Configuration.GetSection("AppSettings")["UserEmail"],
                Email = Configuration.GetSection("AppSettings")["UserEmail"]
            };




            //var UserManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //string userPassword = Configuration.GetSection("AppSettings")["UserPassword"];
            //var user = await UserManager.FindByEmailAsync(Configuration.GetSection("AppSettings")["UserEmail"]);

            //if (user == null)
            //{
            //    var createPowerUser = await UserManager.CreateAsync(poweruser, userPassword);
            //    if (createPowerUser.Succeeded)
            //    {
            //        // here we assign the new user to the "Admin" role
            //        await UserManager.AddToRoleAsync(poweruser, "Admin");
            //    }
            //}
        }
    }
}
