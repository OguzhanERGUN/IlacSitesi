using IlacSitesi.Concreate;
using IlacSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IlacSitesi.Controllers
{
    public class IndicationsController : Controller
    {
        Context DB = new Context();

        public ActionResult Index()
        {
            return View();
        }
        #region Add Indications Page
        [HttpGet]
        public ActionResult AddIndication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddIndication(Indications ındication)
        {
            if (ındication.indications_details != null)
            {
                DB.Indications.Add(ındication);
                DB.SaveChanges();
                return View("SuccessPage");
            }
            else
            {
                return View("FailedPage");
            }
        }

        public ActionResult SuccessPage()
        {
            return View();
        }
        public ActionResult FailedPage()
        {
            return View();
        }
        #endregion
    }
}