using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoeShopping.Data;
using ShoeShopping.Models;
using ShoeShopping.Models.ViewModels;
using ShoeShopping.Ultility;

namespace ShoeShopping.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class BillController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BillController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listBill = _db.Bills.Include(b => b.Users).ToList();
            return View(listBill);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var prodList = (IEnumerable<Products>)(from p in _db.Products
                                                   join b in _db.ProductSelectedForBills
                                                   on p.Id equals b.ProductId
                                                   where b.BillId == id
                                                   select p).Include(p => p.CategoryProducts).Include(p => p.ProductTags);
            var user = (from b in _db.Bills
                        join u in _db.ApplicationUsers
                        on b.UserId equals u.Id
                        where b.Id == id
                        select u).FirstOrDefault();

            BillDetailsViewModel billDetailVM = new BillDetailsViewModel()
            {
                Bills = _db.Bills.Include(b => b.Users).Where(b => b.Id == id).FirstOrDefault(),
                Users = user,
                Products = prodList.ToList()
            };

            return View(billDetailVM);
        }

        //Edit Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BillDetailsViewModel billDetailVM)
        {
            if (id != billDetailVM.Bills.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                return View(billDetailVM);
            }
            billDetailVM.Bills.BillDate = billDetailVM.Bills.BillDate.AddHours(billDetailVM.Bills.BillTime.Hour)
                                                          .AddMinutes(billDetailVM.Bills.BillTime.Minute);
            var billFromDb = await _db.Bills.Where(b => b.Id == billDetailVM.Bills.Id).FirstOrDefaultAsync();

            billFromDb.IsPaid = billDetailVM.Bills.IsPaid;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}