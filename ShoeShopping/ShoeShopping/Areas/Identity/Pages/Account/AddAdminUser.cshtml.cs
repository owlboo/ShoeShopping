using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ShoeShopping.Models;
using ShoeShopping.Ultility;

namespace ShoeShopping.Areas.Identity.Pages.Account
{
    public class AddAdminUserModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        public AddAdminUserModel(
            UserManager<IdentityUser> userManager,

            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> OnGet()
        {
            //Create Roles for our Website And create ADmin USer
            if (!await _roleManager.RoleExistsAsync(SD.SuperAdminEndUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(SD.SuperAdminEndUser));
                var userAdmin = new ApplicationUsers()
                {
                    UserName = "admin@gmail.com",
                    Name = "Main Supper Admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "0912312321"
                };

                var resultUser = await _userManager.CreateAsync(userAdmin, "Admin123*");
                await _userManager.AddToRoleAsync(userAdmin, SD.SuperAdminEndUser);
            }
            if (!await _roleManager.RoleExistsAsync(SD.CustomerUser))
            {
                await _roleManager.CreateAsync(new IdentityRole(SD.CustomerUser));

            }

            
            return Page();
        }
    }
}