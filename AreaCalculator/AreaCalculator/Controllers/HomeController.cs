using System.Diagnostics;
using AreaCalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace AreaCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Area = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AreaCalculatorModel acm) {
            if (ModelState.IsValid) { 
                ViewBag.Area = acm.CalculatorArea();
            } else {
                ViewBag.Area = 0;
            }
            return View(acm);
        }

        public IActionResult Questions()
        {
            return View();
        }

    }
}
