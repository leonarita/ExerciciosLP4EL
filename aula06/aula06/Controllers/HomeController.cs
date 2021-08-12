using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aula06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nova aplicação, nova universidade";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Venha se comunicar conosco!";

            return View();
        }
    }
}