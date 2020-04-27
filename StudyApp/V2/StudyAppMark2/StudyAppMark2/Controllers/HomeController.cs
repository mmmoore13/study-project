using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using StudyAppMark2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudyAppMark2.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Creeting = hour < 12 ? "GoodMorning" : "Good Afternoon";
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your Contact Page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
            //return View(new ErrorViewModel
            //{
            //    RequestID = Activity.Current?.Id
            //        ?? HttpContext.TraceIdentifier
            //});
        }
    }
}
