using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Names()
        {
            // to a View that has defined a model as @model string[]
            string[] names = new string[]
            {
            "Sally", "Billy", "Joey", "Moose"
            };
            return View(names);
        }

        public IActionResult Numbers()
        {
            // to a View that has defined a model as @model int[]
            int[] numbers = new int[4]
            {
            1, 2, -1, 99
            };
            return View(numbers);
        }

        public IActionResult Users()
        {
            // to a View that has defined a model as @model int[]
            List<User> users = new List<User>();
            User cody = new User();
            cody.FirstName = "Cody";
            cody.LastName = "Thaller";
            User cody1 = new User();
            cody1.FirstName = "Cody1";
            cody1.LastName = "Thaller1";
            User cody2 = new User();
            cody2.FirstName = "Cody2";
            cody2.LastName = "Thaller2";

            users.Add(cody);
            users.Add(cody1);
            users.Add(cody2);

            return View(users);
        }
        public IActionResult OneUser()
        {
            // to a View that has defined a model as @model int[]
            User cody = new User();
            cody.FirstName = "Cody";
            cody.LastName = "Thaller";
            return View(cody);
        }
    }
}
