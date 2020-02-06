using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CookieSessions.Models;

namespace CookieSessions.Controllers
{
    public class CookieSessionsController : Controller
    {
        public readonly UserAccountContextcs _context;
        public CookieSessionsController(UserAccountContextcs context)
        {
            this._context = context;
        }
        // GET: CookieSessions
        [Route(" ")]
        [Route("CookieSessions")]
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {

                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.UserName + "has got successfully registered";
                return RedirectToAction("Login");
            }
            catch(Exception e)
            {
                ViewBag.message = uc.UserName + "Registration failed ";
                return View();
            }
           
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount uc)
        {
            var logUser = _context.UserAccounts.Where(e => e.UserName == uc.UserName && e.Password == uc.Password).ToList();
            if (logUser.Count==0)
            {
                ViewBag.message = "Not Valid User";
                return View();
            }
            else
            {//to store session values
                HttpContext.Session.SetString("UName", uc.UserName);
                
               // HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashboard");
            }
            
            return View();
        }
        public ActionResult CreateDashboard()
        {
            if (HttpContext.Session.GetString("UName") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
                //ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
                if(Request.Cookies["Lastlogin"]!=null)
                ViewBag.lldt = Request.Cookies["Lastlogin"].ToString();
            }
            return View();
        }
        public ActionResult LogOut()
        {
            Response.Cookies.Append("Lastlogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: CookieSessions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CookieSessions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookieSessions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSessions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookieSessions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSessions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSessions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}