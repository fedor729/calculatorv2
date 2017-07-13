using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.TwoArgumentsCalculate;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operations = new List<SelectListItem>()
            {
                new SelectListItem {Text = "Plus", Value = "Sum"},
                new SelectListItem {Text = "Minus", Value = "Min"},
                new SelectListItem {Text = "Mult", Value = "Mult"},
                new SelectListItem {Text = "Div", Value = "Div"}
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calculate(double firstValue, double lastValue, string operation)
        {
            var calc = TwoArgumentsFatory.CreateCalculator(operation);
            double resultValue = calc.Calculate(firstValue, lastValue);
            return View(resultValue);
        }
    }
}