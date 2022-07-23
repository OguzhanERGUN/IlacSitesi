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
                return View(DB.MonoklonalAntikors.ToList());
            }
            return View(DB.MonoklonalAntikors.Where(x => x.icd10_code.Contains(searching)).ToList());
        }



        public ActionResult IlacDetay(int id)
        {
            MonoklonalAntikors ılac = DB.MonoklonalAntikors.Where(x => x.ma_id == id).FirstOrDefault();
            return View(ılac);
        }


        [HttpGet]
        public ActionResult IlacEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult IlacEkle(MonoklonalAntikors ılac)
        {
            if (ılac != null)
            {
                DB.MonoklonalAntikors.Add(ılac);
            }
            DB.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult IlacSil(int id)
        {
            MonoklonalAntikors ılac = DB.MonoklonalAntikors.Where(x => x.ma_id == id).FirstOrDefault();
            if (ılac != null)
            {
                DB.MonoklonalAntikors.Remove(ılac);
            }
            DB.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult IlacDuzenle(int id)
        {
            MonoklonalAntikors ılac = DB.MonoklonalAntikors.Where(x => x.ma_id == id).FirstOrDefault();
            return View(ılac);
        }



        [HttpPost]
        public ActionResult IlacDuzenle(MonoklonalAntikors ılac,int id)
        {
            if (ılac != null)
            {
                MonoklonalAntikors temp = DB.MonoklonalAntikors.Where(x => x.ma_id == id).FirstOrDefault();
                
                if (temp != null)
                {
                    temp.icd10_code = ılac.icd10_code;
                    temp.dose = ılac.dose;
                    temp.defined_daily_dose = ılac.defined_daily_dose;
                    temp.Producer.producer_name = ılac.Producer.producer_name;
                    temp.Indications.indications_details = ılac.Indications.indications_details;
                }
                
            }
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}


