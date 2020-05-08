using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Submission")]
        public IActionResult Submission(Survey yourSurvey)
        {
            // Handle your form submission here
            if (ModelState.IsValid)
            {
                return RedirectToAction("Main", yourSurvey);
            }
            else
            {
                return View("Index", yourSurvey);
            }
        }

        public IActionResult Main(Survey yourSurvey)
        {
            return View("Submission", yourSurvey);
        }

    }
}
