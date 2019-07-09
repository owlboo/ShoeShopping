using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoeShopping.Models;
using ShoeShopping.Data;

namespace ShoeShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTagController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductTagController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.ProductTags.ToList());
        }
        //Get Create
        public IActionResult Create()
        {
            return View();
        }
        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTags productTags)
        {
            if (ModelState.IsValid)
            {
                _db.ProductTags.Add(productTags);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productTags);
        }
        //Get Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productTag = await _db.ProductTags.FindAsync(id);
            if (productTag == null)
            {
                return NotFound();
            }
            return View(productTag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        //Post Edit
        public async Task<IActionResult> Edit(int id, ProductTags productTag)
        {
            if (id != productTag.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.ProductTags.Update(productTag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productTag);
        }

        //Get Details
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productTag = _db.ProductTags.Find(id);
            if (productTag == null)
            {
                return NotFound();
            }
            return View(productTag);
        }

        //Get Delete
        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var productTag = _db.ProductTags.Find(id);
            if (productTag == null)
            {
                return NotFound();
            }
            return View(productTag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, ProductTags productTag)
        {
            if (id != productTag.Id)
            {
                return NotFound();
            }
            _db.ProductTags.Remove(productTag);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}