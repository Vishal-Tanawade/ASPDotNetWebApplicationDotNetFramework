using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDotNetWebApplicationDotNetFramework.Controllers
{
    public class CustomerPortalController : Controller
    {
        // GET: CustomerPortal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult RazorDemo()
        {
            return View();
        }

        public ActionResult CustomerDetails()
        {
            ViewData["CustomerCode"] = 1001;
            ViewData["CustomerName"] = "Vishal Tanawade"; // it is like dictionary's key-value pair
            ViewData["CustomerType"] = "Gold Member";               
            ViewBag.MembershipStartDate = DateTime.Now.ToShortDateString(); 
            ViewBag.CustomerStatus = false; // it is like class  property   
            ViewBag.CartItem = new string[] { "Laptop", "Mouse", "Speaker", "Pendrive" };

            return View();
        }
    }
}