using Microsoft.AspNetCore.Mvc;
using Solbeg_calculator.Models;
using System;
using System.Diagnostics;


namespace Solbeg_calculator.Controllers
{
    public class HomeController : Controller
    {
        public CalcModel calc;

        public HomeController()
        {
            calc = new CalcModel();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(string digit_1, string digit_2, string operation)
        {
            calc.Digit_1 = Convert.ToDouble(digit_1);
            calc.Digit_2 = Convert.ToDouble(digit_2);

            switch (operation)
            {
                case "+": calc.Result = calc.Digit_1 + calc.Digit_2; break;
                case "-": calc.Result = calc.Digit_1 - calc.Digit_2; break;
                case "*": calc.Result = calc.Digit_1 * calc.Digit_2; break;
                case "/": calc.Result = calc.Digit_1 / calc.Digit_2; break;
            }
            return View("Index",calc.Result);
        }

        [HttpGet]
        public ViewResult Response1()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
