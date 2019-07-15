using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShoeShopping.Data;
using ShoeShopping.Models;
using ShoeShopping.Models.ViewModels;

namespace ShoeShopping.Areas.Identity.Pages.Account.Manage
{
    public class YourPurchaseModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public CustomerBillViewModel OutputModel { get; set; }
        public YourPurchaseModel(ApplicationDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public List<Bills> Bills { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;

            var listBills = await _db.Bills.Include(b => b.Users).Where(b => b.UserId == userId).ToListAsync();

            Bills = listBills;

            return Page() ;

        }
    }
}