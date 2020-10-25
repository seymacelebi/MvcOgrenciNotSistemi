using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotSistemiMvc.Controllers
{
    public class HesapTestController : Controller
    {
        // GET: HesapTest
        public ActionResult Index(double sayi1 = 0, double sayi2 = 0)
        {
            double toplam = sayi1 + sayi2;
            ViewBag.tplm = toplam;
            double cıkarma = sayi1 - sayi2;
            ViewBag.ckrm = cıkarma;
            double carpma = sayi1 * sayi2;
            ViewBag.crp = carpma;
            double bolme = sayi1 / sayi2;
            ViewBag.blm = bolme;
            ViewBag.sayi1 = sayi1;
            ViewBag.sayi2 = sayi2;
            return View();
        }
    
}
}