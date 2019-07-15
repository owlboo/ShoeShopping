using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoeShopping.Data;
using ShoeShopping.Extensions;
using ShoeShopping.Models;
using ShoeShopping.Models.ViewModels;

namespace ShoeShopping.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingCartController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public ShoppingCartViewModel shoppingCartVM { get; set; }



        public ShoppingCartController(ApplicationDbContext db)
        {
            
            _db = db;
            shoppingCartVM = new ShoppingCartViewModel()
            {
                Products = new List<Models.Products>()
            };

        }

        //Get Index
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.Name);
            if(userId == null || User ==null)
            {
                return LocalRedirect("/Identity/Account/Login");
            }
            List<int> listProd = new List<int>();
            listProd = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if (listProd == null)
            {
                return View("~/Views/Shared/_NoContentError.cshtml");
            }
            if (listProd.Count > 0)
            {
                foreach (int item in listProd)
                {
                    Products prod = _db.Products.Include(p => p.CategoryProducts).Include(p => p.ProductTags).Where(p => p.Id == item).FirstOrDefault();
                    shoppingCartVM.Products.Add(prod);
                }
            }
            return View(shoppingCartVM);

        }
        //Post Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> IndexPost()
        {
            List<int> lstShoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            shoppingCartVM.Bills.BillDate = shoppingCartVM.Bills.BillDate.AddHours(shoppingCartVM.Bills.BillTime.Hour)
                                                                        .AddMinutes(shoppingCartVM.Bills.BillTime.Minute);
            var Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            shoppingCartVM.Bills.UserId = Id;
            Bills bills = shoppingCartVM.Bills;
            _db.Bills.Add(bills);
            _db.SaveChanges();


            int billId = bills.Id;
            foreach (int productId in lstShoppingCart)
            {
                ProductSelectedForBill productSelectedForBill = new ProductSelectedForBill()
                {
                    ProductId = productId,
                    BillId = billId
                };
                _db.ProductSelectedForBills.Add(productSelectedForBill);
            }
            _db.SaveChanges();
            lstShoppingCart = new List<int>();
            HttpContext.Session.Set("ssShoppingCart", lstShoppingCart);
            return RedirectToAction("BillConfirmation", "ShoppingCart", new { id = billId });
        }
        public IActionResult Remove(int id)
        {
            List<int> lstCartItem = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            if (lstCartItem.Count > 0)
            {
                if (lstCartItem.Contains(id))
                {
                    lstCartItem.Remove(id);
                }
            }
            HttpContext.Session.Set("ssShoppingCart", lstCartItem);
            return RedirectToAction(nameof(Index));
        }
        //Get Action method BillConfirmation
        public IActionResult BillConfirmation(int id)
        {
            shoppingCartVM.Bills = _db.Bills.Where(b => b.Id == id).FirstOrDefault();
            List<ProductSelectedForBill> listProd = _db.ProductSelectedForBills.Where(p => p.BillId == id).ToList();
            foreach (ProductSelectedForBill item in listProd)
            {
                shoppingCartVM.Products.Add(_db.Products.Include(p => p.CategoryProducts).Include(p => p.ProductTags).Where(p => p.Id == item.ProductId).FirstOrDefault());

            }
            return View(shoppingCartVM);
        }
    }
}