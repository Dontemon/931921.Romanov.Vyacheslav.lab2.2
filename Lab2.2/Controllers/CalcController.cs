using Lab2._2.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Diagnostics;

namespace Lab2._2.Controllers
{
    public class CalcController : Controller
    {
        private readonly ILogger<CalcController> _logger;

        public CalcController(ILogger<CalcController> logger)
        {
            _logger = logger;
        }

        public IActionResult ManualParsingInSingleAction()
        {
           if (Request.Method != "POST")
               return View();
            else
            {
                CalcModel model = new CalcModel();
                model.first = Request.Form["first"];
                model.second = Request.Form["second"];
                model.sign = Request.Form["sign"];
                model.show = false;
                model.calculation();
                ViewBag.dataModel = model;
                return View("Results");
            }
        }
        [HttpGet]
        public IActionResult ManualParsingInSeparateActions()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ManualParsingInSeparateActions(int temp)
        {
            CalcModel model = new CalcModel();
            model.first = Request.Form["first"];
            model.second = Request.Form["second"];
            model.sign = Request.Form["sign"];
            model.show = false;
            model.calculation();
            ViewBag.dataModel = model;
            return View("Results");
        }
        [HttpGet]
        public IActionResult ModelBindingParametrs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ModelBindingInParametrs(string first, string second, string sign)
        {
            CalcModel model = new CalcModel();
            model.first = Request.Form["first"];
            model.second = Request.Form["second"];
            model.sign = Request.Form["sign"];
            model.show = false;
            model.calculation();
            ViewBag.dataModel = model;
            return View("Results");
        }
        [HttpGet]
        public IActionResult ModelBindingInSeparateModel()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ModelBindingInSeparateModel(CalcModel model)
        {
            model.show = true;
            model.calculation();
            ViewBag.dataModel = model;
            return View("Results");
        }
    }
}