using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228Allup.DAL;
using P228Allup.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using P228Allup.ViewModels;

namespace P228Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(int pageIndex)
        {
            IQueryable<Category> categories = _context.Categories
                .Include(c => c.Products)
                .Where(c => c.IsDeleted == false && c.IsMain);

            return View(PageNationList<Category>.Create(categories, pageIndex, 3));
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id Null Ola Bilmez");
            }

            Category category = await _context.Categories
                .Include(c => c.Products)
                .Include(c=>c.Children)
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.IsMain && c.Id == id);

            if (category == null)
            {
                return NotFound("Id Yanlisdir");
            }

            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsDeleted == false && c.IsMain)
                .ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsDeleted == false && c.IsMain)
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(category);
            }

            if (await _context.Categories.AnyAsync(c=>c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim()))
            {
                ModelState.AddModelError("Name", $"This Name = {category.Name} Alreade Exists");
                return View(category);
            }

            if (category.IsMain)
            {
                if (category.File == null)
                {
                    ModelState.AddModelError("File", "Fayl Mecburidi");
                    return View(category);
                }

                if (category.File.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("File", "Fayl Tipi .jpg ve ya .jpeg olmalidir");
                    return View(category);
                }

                if ((category.File.Length / 1024) > 20)
                {
                    ModelState.AddModelError("File", "Fayl Olcusu maksimum 20 kb olmalidir");
                    return View(category);
                }

                string fileName = Guid.NewGuid().ToString()+"-"+DateTime.UtcNow.AddHours(4).ToString("yyyyMMddHHmmss")+"-"+category.File.FileName;

                string path = @"C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\wwwroot\assets\images\" + fileName;

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    await category.File.CopyToAsync(fileStream);
                }

                category.ParentId = null;
                category.Image = fileName;
            }
            else
            {
                if (category.ParentId == null)
                {
                    ModelState.AddModelError("ParentId", "Ust Category Mutleq Secilmelidir");
                    return View(category);
                }

                if (!await _context.Categories.AnyAsync(c=>c.IsDeleted == false && c.IsMain && c.Id == category.ParentId))
                {
                    ModelState.AddModelError("ParentId", "Duzgun Ust Category Sec");
                    return View(category);
                }

                category.Image = null;
            }

            category.Name = category.Name.Trim();
            category.IsDeleted = false;
            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            category.CreatedBy = "System";

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            ViewBag.Categories = await _context.Categories
                .Where(c => c.IsDeleted == false && c.IsMain)
                .ToListAsync();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Category category)
        {
            ViewBag.Categories = await _context.Categories
               .Where(c => c.IsDeleted == false && c.IsMain)
               .ToListAsync();

            if (!ModelState.IsValid)
            {
                return View(category);
            }

            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (category.Id != id)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            if (await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.Name.ToLower() == category.Name.ToLower().Trim() && c.Id != id))
            {
                ModelState.AddModelError("Name", $"This Name = {category.Name} Alreade Exists");
                return View(category);
            }

            Category existedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (existedCategory == null)
            {
                return NotFound("Daxil Edilen Id Yanlisir");
            }

            if (category.IsMain)
            {
                if (existedCategory.Image == null && category.File == null)
                {
                    ModelState.AddModelError("File", "Fayl Mecburidi");
                    return View(category);
                }

                if (category.File != null )
                {
                    if (category.File.ContentType != "image/jpeg")
                    {
                        ModelState.AddModelError("File", "Fayl Tipi .jpg ve ya .jpeg olmalidir");
                        return View(category);
                    }

                    if ((category.File.Length / 1024) > 20)
                    {
                        ModelState.AddModelError("File", "Fayl Olcusu maksimum 20 kb olmalidir");
                        return View(category);
                    }

                    //string path = @"C:\Users\hamid.mammadov\Desktop\P228Allup\P228Allup\wwwroot\assets\images\";

                    string path = Path.Combine(_env.WebRootPath, "assets", "images");

                    string oldPath = Path.Combine(path, existedCategory.Image);

                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }

                    string fileName = Guid.NewGuid().ToString() + "-" + DateTime.UtcNow.AddHours(4).ToString("yyyyMMddHHmmss") + "-" + category.File.FileName;

                    string fullpath = Path.Combine(path,fileName);

                    using (FileStream fileStream = new FileStream(fullpath, FileMode.Create))
                    {
                        await category.File.CopyToAsync(fileStream);
                    }

                    existedCategory.ParentId = null;
                    existedCategory.Image = fileName;
                }
            }
            else
            {
                if (category.ParentId == null)
                {
                    ModelState.AddModelError("ParentId", "Ust Category Mutleq Secilmelidir");
                    return View(category);
                }

                if (!await _context.Categories.AnyAsync(c => c.IsDeleted == false && c.IsMain && c.Id == category.ParentId))
                {
                    ModelState.AddModelError("ParentId", "Duzgun Ust Category Sec");
                    return View(category);
                }

                existedCategory.Image = null;
                existedCategory.ParentId = category.ParentId;
            }

            existedCategory.IsMain = category.IsMain;
            existedCategory.Name = category.Name.Trim();
            existedCategory.UpdatedAt = DateTime.UtcNow.AddHours(4);
            existedCategory.UpdatedBy = "System";

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Id Bos Ola Bilmez");
            }

            Category category = await _context.Categories
                .Include(c => c.Products)
                .Include(c => c.Children)
                .FirstOrDefaultAsync(c => c.IsDeleted == false && c.Id == id);

            if (category == null)
            {
                return NotFound("Id Yanlisdir");
            }

            if ((category.Products != null && category.Products.Count() > 0) || (category.Children != null && category.Children.Count() > 0))
            {
                TempData["Error"] = $"Id = {id} li Category Siline Bilmez";

                return RedirectToAction("Index");
            }

            //category.IsDeleted = true;
            //category.DeletedBy = "";
            //category.DeletedAt = DateTime.UtcNow.AddHours(+4);

            //await _context.Categories.AddRangeAsync();

            //_context.Products.RemoveRange(category.Products);
            //_context.Categories.RemoveRange(category.Children);

            //_context.Categories.Remove(category);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
