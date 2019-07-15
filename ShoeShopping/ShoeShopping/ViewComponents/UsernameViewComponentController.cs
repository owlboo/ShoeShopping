using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoeShopping.Data;

namespace ShoeShopping.ViewComponents
{
    public class UsernameViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public UsernameViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var userFromDb = await _db.ApplicationUsers.Where(u => u.Id == claim.Value).FirstOrDefaultAsync();

            return View(userFromDb);
        }
    }
}