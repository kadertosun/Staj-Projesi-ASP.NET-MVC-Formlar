using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetintAIFormlar.Models;

namespace SetintAIFormlar.Controllers
{
    public class DoktorController : Controller
    {
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Doktor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Doktor(DoktorDb p)
        {
            Db.DoktorDb.Add(p);
            Db.SaveChanges();
            return View();
        }
    }
}

