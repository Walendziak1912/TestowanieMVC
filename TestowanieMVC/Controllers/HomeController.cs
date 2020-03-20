using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestowanieMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Imie = "Lis";
            return View();
        }
        public ViewResult Odpowiedz()
        {
            return View();
        }
    }
}