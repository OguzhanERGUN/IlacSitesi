using IlacSitesi.Concreate;
using IlacSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IlacSitesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Context DB = new Context();



        public ActionResult Index(string searching)
        {
            if (searching == null || searching == "")
            {
                return View(DB.Ilacs.ToList());
            }
            return View(DB.Ilacs.Where(x => x.IlacAdi.Contains(searching)).ToList());
        }



        public ActionResult IlacDetay(int id)
        {
            Ilac ılac = DB.Ilacs.Where(x => x.IlacID == id).FirstOrDefault();

            return View(ılac);
        }


        [HttpGet]
        public ActionResult IlacEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IlacEkle(Ilac ılac)
        {
            if (ılac != null)
            {
                DB.Ilacs.Add(ılac);
            }
            DB.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult IlacSil(int id)
        {
            Ilac ılac = DB.Ilacs.Where(x => x.IlacID == id).FirstOrDefault();
            if (ılac != null)
            {
                DB.Ilacs.Remove(ılac);
            }
            DB.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult IlacDuzenle(int id)
        {
            Ilac ılac = DB.Ilacs.Where(x => x.IlacID == id).FirstOrDefault();
            return View(ılac);
        }



        [HttpPost]
        public ActionResult IlacDuzenle(Ilac ılac)
        {
            if (ılac != null)
            {
                Ilac temp = DB.Ilacs.Where(x => x.IlacID == ılac.IlacID).FirstOrDefault();
                
                if (temp != null)
                {
                    temp.IlacID = ılac.IlacID;
                    temp.IlacAdi = ılac.IlacAdi;
                    temp.Price = ılac.Price;
                    temp.StokAdedi = ılac.StokAdedi;
                    temp.Description = ılac.Description;
                }
                
            }
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}


