using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortfolioII.Models;

namespace PortfolioII.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projects()
        {

            List<Project> projects = new List<Project>();
            

            projects.Add(new Project("Project 1", "https://place-hold.it/50x50", "Super dope description 1"));
            projects.Add(new Project("Project 2", "https://place-hold.it/50x50", "Super dope description 2"));
            projects.Add(new Project("Project 3", "https://place-hold.it/50x50", "Super dope description 3"));
            return View(projects);
        }

        public IActionResult Contacts()
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
