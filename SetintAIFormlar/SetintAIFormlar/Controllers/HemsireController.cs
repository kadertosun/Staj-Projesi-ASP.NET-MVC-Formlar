using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetintAIFormlar.Models;

namespace SetintAIFormlar.Controllers
{
    public class HemsireController : Controller
    {
        // GET: Hemsire
        FormEntities Db = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Hemsire()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Hemsire(RobotDb veri)
        {
            if (ModelState.IsValid)
            {
                Db.RobotDb.Add(veri);
                Db.SaveChanges();
                ViewBag.SuccessMsg = "successfully added";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}