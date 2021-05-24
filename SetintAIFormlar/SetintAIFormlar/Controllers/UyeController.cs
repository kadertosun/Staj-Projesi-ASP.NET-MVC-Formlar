using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetintAIFormlar.Models;

namespace SetintAIFormlar.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeEkle(UyeDb p)
        {
            Db.UyeDb.Add(p);
            Db.SaveChanges();
            return View();
        }
    }
}