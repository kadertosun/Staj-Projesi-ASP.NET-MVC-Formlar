using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetintAIFormlar.Models;

namespace SetintAIFormlar.Controllers
{
    public class SaglikController : Controller
    {
        // GET: Saglik
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Saglik()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Saglik(KurulusDb veri)
        {
            Db.KurulusDb.Add(veri);
            Db.SaveChanges();
            return View();
        }
    }
}