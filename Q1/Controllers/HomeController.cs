using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Q1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Company()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Collaboration()
        {
            return View();
        }
    }
}