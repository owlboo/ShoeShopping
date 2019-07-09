using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ShoeShopping.Ultility;
using ShoeShopping.Data;
using ShoeShopping.Models.ViewModels;

namespace ShoeShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly HostingEnvironment _hostingEnvironment;
        [BindProperty]
        public ProductsViewModel productsVM { get; set; }
        public ProductController(ApplicationDbContext db, HostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            productsVM = new ProductsViewModel()
            {
                
                CategoryProducts = _db.CategoryProducts.ToList(),
                ProductTags = _db.ProductTags.ToList(),
                Products = new Models.Products()
            };

        }

        public async Task<IActionResult> Index()
        {
            var products = _db.Products.Include(m => m.ProductTags).Include(m => m.CategoryProducts);
            return View(await products.ToListAsync());
        }

        #region Create
        //Get Create
        public IActionResult Create()
        {
            return View(productsVM);
        }
        //Post Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(productsVM);
            }
            _db.Products.Add(productsVM.Products);
            await _db.SaveChangesAsync();

            //Image being saved

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var productsFromDB = _db.Products.Find(productsVM.Products.Id);
            if (files.Count != 0)
            {
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);
                var names = productsVM.Products.Name.ToLower().Split(" ");
                var completed_name = "";
                foreach (var item in names)
                {
                    completed_name += item;
                }
                using (var filestream = new FileStream(Path.Combine(uploads, completed_name + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                productsFromDB.Image = @"\" + SD.ImageFolder + @"\" + completed_name + extension;
            }
            else
            {
                // when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);

                var names = productsVM.Products.Name.ToLower().Split(" ");
                var completed_name = "";
                foreach (var item in names)
                {
                    completed_name += item;
                }
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + completed_name + ".jpg");
                productsFromDB.Image = @"\" + SD.ImageFolder + @"\" + completed_name + ".jpg";
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
        #region Edit
        //Get Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            productsVM.Products = await _db.Products.Include(m => m.CategoryProducts).Include(m => m.ProductTags).SingleOrDefaultAsync(m => m.Id == id);

            if (productsVM.Products == null)
            {
                return NotFound();
            }
            return View(productsVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                var productsFromDB = _db.Products.Where(m => m.Id == productsVM.Products.Id).FirstOrDefault();
                var names = productsVM.Products.Name.ToLower().Split(" ");
                var completed_name = "";
                foreach (var item in names)
                {
                    completed_name += item;
                }
                if (files.Count > 0 && files[0] != null)
                {


                    //if user uploads  image
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extension_new = Path.GetExtension(files[0].FileName);
                    var extension_old = Path.GetExtension(productsFromDB.Image);

                    if (System.IO.File.Exists(Path.Combine(uploads, completed_name + extension_old)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, completed_name + extension_old));
                    }
                    using (var filestream = new FileStream(Path.Combine(uploads, completed_name + extension_new), FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    productsVM.Products.Image = @"\" + SD.ImageFolder + @"\" + completed_name + extension_new;

                }
                productsFromDB.Name = productsVM.Products.Name;
                
                productsFromDB.Material = productsVM.Products.Material;
                productsFromDB.Origin = productsVM.Products.Origin;
                productsFromDB.CategoryProductId = productsVM.Products.CategoryProductId;
                productsFromDB.ProductTagId = productsVM.Products.ProductTagId;
                productsFromDB.Discount = productsVM.Products.Discount;
                if(productsVM.Products.Discount != 0)
                {
                    var discount = Convert.ToInt32((productsVM.Products.Price * (productsVM.Products.Discount / 100f)));
                    productsFromDB.New_Price = productsFromDB.Price - discount;                 
                }
                else
                {
                    productsFromDB.Price = productsVM.Products.Price;
                }
                productsFromDB.Available = productsVM.Products.Available;
                productsFromDB.Gender = productsVM.Products.Gender;
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(productsVM);
        }
        #endregion
    }
}