using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dailyfoods.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult cart()
        {
            return View();
        }
        public ActionResult checkout()
        {
            return View();
        }
        public ActionResult order_recieved()
        {
            return View();
        }
    }
}