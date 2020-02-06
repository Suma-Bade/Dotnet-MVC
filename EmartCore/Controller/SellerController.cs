using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmartCore.Models;

namespace EmartCore.Controllers
{
    public class SellerController : Controller
    {
        private readonly ISellerRepository sellerRepository;
        // ISellerRepository sellerRepository = new SellerRepository();
        public SellerController(ISellerRepository selRepository)
        {
           sellerRepository = selRepository;
        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Seller sell = sellerRepository.GetSeller(ID);
            return View(sell);

            //Seller sel = sellerRepository.GetSeller(1);
            //return sel.id+"\n"+sel.name + "\n" + sel.password + "\n" + sel.emailid + "\n" + sel.mobileno + "\n" + sel.companyname + "\n" + sel.briefabtcmpy + "\n" + sel.address + "\n" + sel.website + "\n" + sel.GST;
        }
        public IActionResult Index()
        {
            List<Seller> slist = sellerRepository.DisplayDetails();
            return View(slist);
        }
        //public string Index()
        //{
        //    return "Hello from index";
        //}
        //public ViewResult AboutUs()
        //{
        //    return View();
        //}
        public IActionResult GetAllSellers()
        {
            List<Seller> slist = sellerRepository.DisplayDetails().Where(s => s.companyname == "cts").ToList();
            return View("Index", slist);
        }

    }
}
