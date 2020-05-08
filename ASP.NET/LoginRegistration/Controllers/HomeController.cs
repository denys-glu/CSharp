using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");

                    // You may consider returning to the View at this point
                    return View("Index");
                }
                PasswordHasher<RegisterUser> Hasher = new PasswordHasher<RegisterUser>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                dbContext.Add(newUser);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("UserID", newUser.UserID.ToString());
                return RedirectToAction("Main");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser user)
        {

            if (ModelState.IsValid)
            {

                RegisterUser dbUser = dbContext.Users.FirstOrDefault(u => u.Email == user.LoginEmail);

                if (dbUser == null)
                {
                    ModelState.AddModelError("LoginEmail", "SOmething went wrong with your Email/password, are you registered and used right password?");
                    return View("Index");
                }

                PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
                var result = Hasher.VerifyHashedPassword(user, dbUser.Password, user.LoginPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "SOmething went wrong with your Email/password, are you registered and used right password?");
                    return View("Index");
                }
                HttpContext.Session.SetString("UserID", dbUser.UserID.ToString());
                return RedirectToAction("Main");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("/main")]
        public IActionResult Main()
        {
            if (HttpContext.Session.GetString("UserID") == null)
            {
                return View("Index");
            }
            return View();
        }
    }
}
