using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string MyPage()
        {
            return "Hi";
        }
        public JsonResult MyPage1()
        {
            return Json("{id:1;name:hi}",JsonRequestBehavior.AllowGet);
        }
        public ViewResult MyPage2()
        {
            return View();
        }
    }
}