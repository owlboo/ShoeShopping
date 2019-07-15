using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoeShopping.Data;
using ShoeShopping.Models;
using ShoeShopping.Ultility;

namespace ShoeShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminUserController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public AdminUserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listSuperAdmin = (IEnumerable<ApplicationUsers>)(from u in _db.ApplicationUsers
                                                                 join u_role in _db.UserRoles
                                                                 on u.Id equals u_role.UserId
                                                                 join r in _db.Roles
                                                                 on u_role.RoleId equals r.Id
                                                                 where r.Name ==SD.SuperAdminEndUser
                                                                 select u
                                                                 ).ToList();

                                                                 
            return View(listSuperAdmin);
        }
    }
}