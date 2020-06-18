using System;
using Microsoft.AspNetCore.Mvc;

namespace PiggyvestCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}