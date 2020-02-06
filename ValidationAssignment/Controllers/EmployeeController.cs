using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationAssignment.Models;
using ValidationAssignment.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ValidationAssignment.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            EmpRepository repository = new EmpRepository();
            repository.Add(emp);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int eid, string pwd)
        {
            EmpRepository repository = new EmpRepository();
            Employee e = repository.Validate(eid, pwd);
            if (e != null)
            {
                return RedirectToAction("Details", e);
            }
            else
            {
                ViewData["error"] = "Invalid credentials";
                return View();
            }
        }
        public IActionResult Details(Employee emp)
        {
            return View(emp);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }


    }


}
    
