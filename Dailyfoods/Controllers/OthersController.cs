using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dailyfoods.Controllers
{
    public class OthersController : Controller
    {
        // GET: Others
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        public ActionResult aboutus()
        {
            return View();
        }
        public ActionResult term_condition()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
    }
}