using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestowanieMVC.Models;

namespace TestowanieMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Imie = "Lis";
            //return View("NaukaHTML");
            return View("Login");
        }
        [HttpGet]
        public ViewResult Odpowiedz()
        {
            return View();
        }

        public ViewResult Odpowiedz(Osoba OsobaResponce)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else 
            {
                return View("Podziekowanie", OsobaResponce);
            }
            
        }


    }
}