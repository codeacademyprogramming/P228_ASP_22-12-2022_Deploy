using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    //[Authorize]
    public class DashboardController : Controller
    {
        //[Authorize(Roles ="SuperAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
