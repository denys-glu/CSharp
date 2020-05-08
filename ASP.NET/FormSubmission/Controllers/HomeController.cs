using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Submit")]
        public IActionResult Submit(User user){
            if(ModelState.IsValid)
            {
                return RedirectToAction("Main", user);
            }
            else 
            {
                return View("Index", user);
            }
        }

        public IActionResult Main()
        {
            return View();
        }
    }
}
