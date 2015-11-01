using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopDog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The Hyper Active Trader";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Notable sources";

            return View();
        }
        public ActionResult HyperActiveTrader()
        {
            ViewBag.Message = "The HyperActive Trader";
            return View();
        }
    }
}