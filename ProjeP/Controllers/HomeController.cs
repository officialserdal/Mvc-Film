using ProjeP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeP.Controllers
{
    public class HomeController : Controller
    {
        context db = new context();
        public ActionResult Index()
        {
            var degerler = db.Filmler.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            var degerler = db.Önerilen_Filmlers.ToList();
            return View(degerler);

           
        }

        
    }
}