using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetintAIFormlar.Models;
namespace SetintAIFormlar.Controllers
{
    public class CalistayController : Controller
    {
        // GET: Calistay
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Calistay()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calistay(CalistayDb p)
        {
            Db.CalistayDb.Add(p);
            Db.SaveChanges();
            return View();
        }
    }
}