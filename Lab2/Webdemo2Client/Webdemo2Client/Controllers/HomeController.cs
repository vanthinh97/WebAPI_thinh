using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webdemo2Client.Controllers
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

        public ActionResult ListProduct()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AddProduct()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult DeleteProduct()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult EditProduct()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}