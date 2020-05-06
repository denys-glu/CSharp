using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(string name, string location, string favLanguage, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.favLanguage = favLanguage;
            ViewBag.comment = comment;
            // Do something with form input
            return View();
        }
    }
}
