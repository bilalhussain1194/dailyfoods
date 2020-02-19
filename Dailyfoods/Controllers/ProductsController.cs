using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dailyfoods.Models;
using Dailyfoods.Viewmodel;

namespace Dailyfoods.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        } 
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
      
        [Authorize(Roles ="superadmin")]
      
        public ActionResult AddProduct()
        {
            var productviewmodel = new AddProductViewmodel
            {
                category_list = _context.category.ToList()
            };
            return View(productviewmodel);
        }
    }
}