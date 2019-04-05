using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Lab1()
        {
            ViewData["Message"] = "Description of laboratory 1";

            return View();
        }

        public IActionResult Lab2()
        {
            ViewData["Message"] = "Description of laboratory 2";

            return View();
        }

        public IActionResult Lab3()
        {
            ViewData["Message"] = "Description of laboratory 3";

            return View();
        }

        public IActionResult Lab4()
        {
            ViewData["Message"] = "Description of laboratory 4";

            return View();
        }

        public IActionResult Planner()
        {
            ViewData["Message"] = "Interactive day planner";

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
