using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228Allup.DAL;
using P228Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P228Allup.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace P228Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //List<Setting> settings = _context.Settings.ToList();
            //ViewBag.Settings = settings;

            //List<Slider> sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync();

            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true).ToListAsync(),
                NewArrival = await _context.Products.Where(p => p.IsDeleted == false && p.IsNewArrival).ToListAsync(),
                BesSeller = await _context.Products.Where(p => p.IsDeleted == false && p.IsBestSeller).ToListAsync(),
                Featured = await _context.Products.Where(p => p.IsDeleted == false && p.IsFeatured).ToListAsync(),
            };

            return View(homeVM);
        }

        //public async Task<IActionResult> NicatSetCocckie()
        //{
        //    Product product = await _context.Products.FirstAsync();

        //    string pro = JsonConvert.SerializeObject(product);

        //    HttpContext.Response.Cookies.Append("basket", pro);

        //    return Ok();
        //}

        //public async Task<IActionResult> NicatGetCoockie()
        //{
        //    string pro = HttpContext.Request.Cookies["basket"];

        //    return Json(pro);
        //}

        //public async Task<IActionResult> test()
        //{
        //    HttpContext.Response.Cookies.Append("P228", "MyFirstCoockie");


        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> test1()
        //{
        //    //HttpContext.Response.Cookies.Append("P228", "MyFirstCoockie");

        //    string a = HttpContext.Request.Cookies["P228"];



        //    return Content(HttpContext.Request.Cookies["P228"]);
        //}

        //public async Task<IActionResult> deletecoockie()
        //{
        //    //HttpContext.Response.Cookies.Append("P228", "MyFirstCoockie");
        //    HttpContext.Response.Cookies.Delete("P228");

        //    return Content("Coockie Silindi");
        //}

        //public async Task<IActionResult> deletesession()
        //{
        //    //HttpContext.Session.SetString("P228", "My First Session");

        //    HttpContext.Session.Remove("p228");

        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> SetSession()
        //{
        //    HttpContext.Session.SetString("P228", "My First Session");

        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> GetSession()
        //{
        //    //HttpContext.Session.GetString("P228");

        //    return Content(HttpContext.Session.GetString("P228"));
        //}
    }
}
