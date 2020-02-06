using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelValidations.Models;
using ModelValidations.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ModelValidations.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { " ","India", "China", "Us", "UK" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
        ////public IActionResult Create()
        ////{
        ////    ViewBag.Country = new SelectList(new string[] { "India", "China", "Us", "UK" });
        ////    return View();
        ////}
        ////[HttpPost]
        ////public IActionResult Create(User item)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        return RedirectToAction("Index");
        ////    }
        ////    else
        ////    {
        ////        return View();
        ////    }
        ////}
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["error"] = "Invalid credentials";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name")]User item)
        {
            return View(item);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }
            

    }
    

}