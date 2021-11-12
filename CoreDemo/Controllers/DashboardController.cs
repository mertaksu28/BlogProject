using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context contex = new Context();
            ViewBag.value1 = contex.Blogs.Count().ToString();
            ViewBag.value2 = contex.Blogs.Where(b => b.WriterId == 1).Count();
            ViewBag.value3 = contex.Categories.Count();
            return View();
        }
    }
}
