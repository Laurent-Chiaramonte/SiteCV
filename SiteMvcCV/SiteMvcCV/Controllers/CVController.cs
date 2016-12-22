using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMvcCV.Controllers.CV
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Competences()
        {
            return View();
        }

        public ActionResult Diplomes()
        {
            return View();
        }

        public ActionResult Experiences()
        {
            return View();
        }

        public ActionResult Divers()
        {
            return View();
        }
    }
}