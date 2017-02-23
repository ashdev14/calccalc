using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProj1.Controllers
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
        public ActionResult Calculus()
        {
            ViewBag.Title = "Calculus";
            ViewBag.Author = "Ashwin";
            return View();
        }
        public ActionResult FirstDerivative()
        {
            ViewBag.Title = "First Derivative";
            return View();
        }

    }
}