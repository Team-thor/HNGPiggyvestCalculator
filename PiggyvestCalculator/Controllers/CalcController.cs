using System;
using Microsoft.AspNetCore.Mvc;

namespace PiggyvestCalculator.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string amount, string interestRate, double numberOfYears)
        {
           
            return View();
        }

         [HttpGet]
        public IActionResult Interest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Interest(string amount, string interestRate, double numberOfYears)
        {
            float intRate = float.Parse(interestRate);
            double amountOfMoney= double.Parse(amount);
            double interestRates = double.Parse(interestRate);
            double interest = (amountOfMoney * interestRates * numberOfYears) / 100;
            
            ViewBag.amount = intRate;
            ViewBag.amountOfMoney = amountOfMoney;
            ViewBag.interestRates = interestRates;
            ViewBag.interest = interest;

            ViewBag.Result = $"Your interest for ₦{amountOfMoney} with an interest rate of {intRate}% in {numberOfYears} years is ₦{interest}";
            return View();
        }
    }
}