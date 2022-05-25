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

    }
}