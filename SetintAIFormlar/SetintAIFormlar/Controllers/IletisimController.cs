using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetintAIFormlar.Models;

namespace SetintAIFormlar.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Iletisim(IletisimDb p)
        {
            Db.IletisimDb.Add(p);
            Db.SaveChanges();
            return View();
        }
    }
}