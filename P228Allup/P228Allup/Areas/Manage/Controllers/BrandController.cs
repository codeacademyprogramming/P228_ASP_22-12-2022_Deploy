using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228Allup.DAL;
using P228Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P228Allup.ViewModels;

namespace P228Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    //[Authorize(Roles ="SuperAdmin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageIndex)
        {
            IQueryable<Brand> brands = _context
                .Brands
                .Where(b => b.IsDeleted == false)
                .OrderByDescending(b => b.Id);
            //int totalPages = (int)Math.Ceiling((decimal)brands.Count() / 3);

            //if (pageIndex < 1 || pageIndex > totalPages)
            //{
            //    pageIndex = 1;
            //}

            //brands = brands
            //    .Skip((pageIndex - 1) * 3)
            //    .Take(3);

            //ViewBag.TotalPages = totalPages;
            //ViewBag.PageIndex = pageIndex;

            return View(PageNationList<Brand>.Create(brands,pageIndex,3));
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return Content(brand.Name);
        }
    }
}
