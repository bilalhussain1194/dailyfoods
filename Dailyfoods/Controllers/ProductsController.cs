using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dailyfoods.Models;
using Dailyfoods.Viewmodel;
using System.IO;
using System.Data.Entity;

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
        [Authorize(Roles = "superadmin")]
        [HttpGet]
        public ActionResult products_details()
        {
           var productlist = _context.product.Include(c => c.category).ToList();
            return View(productlist);
        }
       
        [Authorize(Roles = "superadmin")]
        [HttpGet]
        public ActionResult AddProductform()
        {
        
            var productviewmodel = new AddProductViewmodel
            {
                category_list = _context.category.ToList()
            };
            return View("AddProduct", productviewmodel);
        }

        //public ActionResult AddProduct(AddProductViewmodel addproductviewmodel, List<HttpPostedFileBase> FileUpload)
        //{

        //    var productviewmodel = new AddProductViewmodel
        //    {
        //        category_list = _context.category.ToList()
        //    };
        //    return View(productviewmodel);
        //}
        [ValidateInput(false)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(AddProductViewmodel ProductFormData)
        {
            if (ModelState.IsValid)
            {
                var productdetail = new Product()
                {
                    name = ProductFormData.products.name,
                    sku = ProductFormData.products.sku,
                    description = ProductFormData.products.description,
                    price = ProductFormData.products.price,
                    special_price = ProductFormData.products.special_price,
                    date_from = ProductFormData.products.date_from,
                    date_to = ProductFormData.products.date_to,
                    created_date = DateTime.Now,
                    categoryid = ProductFormData.category.id,
                    qty=ProductFormData.products.qty

                     

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
                ProductFormData.products = productdetail;
                ProductFormData.products.images = imageDetails;


                _context.product.Add(ProductFormData.products);


                _context.SaveChanges();
                //ViewBag.successmessage = "Product successfully created";
                return RedirectToAction("AddProductform");
            }
            else
            {

                var productviewmodel = new AddProductViewmodel
                {
                    category_list = _context.category.ToList()
                };
                return View(productviewmodel);




            }
        }
    }
}
