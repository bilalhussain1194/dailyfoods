using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dailyfoods.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Shop()
        {

            return View();
        }
        public ActionResult product_description()
        {
            return View();
        }
    }
}