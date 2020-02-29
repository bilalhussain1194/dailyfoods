using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dailyfoods.Viewmodel;
using Dailyfoods.Models;
using System.IO;

namespace Dailyfoods.Controllers
{
    public class testingController : Controller
    {
        private ApplicationDbContext _context;
        public testingController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
        // GET: testing
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            var productviewmodel = new AddProductViewmodel()
            {
                category_list = _context.category.ToList()
            };
            return View(productviewmodel);
        }
   


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddProductViewmodel ProductFormData)
        {
            if (ModelState.IsValid)
            {
                var productdetail = new Product()
                {
                    name = ProductFormData.products.name,
                    sku=ProductFormData.products.sku,
                    description=ProductFormData.products.description,
                    price=ProductFormData.products.price,
                    special_price=ProductFormData.products.special_price,
                    date_from=ProductFormData.products.date_from,
                    date_to=ProductFormData.products.date_to,
                    created_date=ProductFormData.products.created_date,
                    //categoryID=ProductFormData.category.id

                };
                List<Images> imageDetails = new List<Images>();
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];

                    if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        Images imageDetail = new Images()
                        {
                            filename = fileName,
                            extension = Path.GetExtension(fileName),
                            id = Guid.NewGuid()
                        };
                        imageDetails.Add(imageDetail);

                        var path = Path.Combine(Server.MapPath("~/ProductImages/"), imageDetail.id + imageDetail.extension);
                        file.SaveAs(path);
                    }
                }

                ProductFormData.products.images = imageDetails;
              
                _context.product.Add(ProductFormData.products);
               
               
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("index");
        }
    }
}