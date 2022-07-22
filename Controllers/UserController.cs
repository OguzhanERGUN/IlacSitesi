using IlacSitesi.Concreate;
using IlacSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IlacSitesi.Controllers
{
    public class UserController : Controller
    {
        Context DB = new Context();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult HesapGiris()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HesapGiris(User user)
        {
            if (user.UserMail == "Admin@hotmail.com" && user.UserPassword == "AdminAdmin")
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("UserGirisi");
            }
            
        }

        public ActionResult UserGirisi(string searching)
        {
            if (searching == null || searching == "")
            {
                return View(DB.MonoklonalAntikors.ToList());
            }
            return View(DB.MonoklonalAntikors.Where(x => x.icd10_code.Contains(searching)).ToList());
        }
        public ActionResult UserDetayGoruntule(int id)
        {
            MonoklonalAntikors ılac = DB.MonoklonalAntikors.Where(x => x.ma_id == id).FirstOrDefault();

            return View(ılac);
        }

    }
}