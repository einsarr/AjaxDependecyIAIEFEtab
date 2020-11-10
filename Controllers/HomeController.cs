using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependenceAjax.Models;

namespace DependenceAjax.Controllers
{
    public class HomeController : Controller
    {
        private DBAjaxDependencyContext db = new DBAjaxDependencyContext();
        public ActionResult Index()
        {
            ViewBag.ias = db.iAs.ToList();
            return View();
        }
        public ActionResult loadIEF(int iaID)
        {
            return Json(db.iEFs.Where(e => e.IAId == iaID).Select(e => new
            {
                Id = e.Id,
                NomIEF = e.NomIEF
            }).ToList(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult loadEtab(int IEFID)
        {
            return Json(db.etablissements.Where(et => et.IEFId == IEFID).Select(et => new
            {
                Id = et.Id,
                NomEtablissement = et.NomEtablissement
            }).ToList(), JsonRequestBehavior.AllowGet);
        }


    }
}