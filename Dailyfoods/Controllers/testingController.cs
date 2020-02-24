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
        public ActionResult create()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddProductViewmodel productviewmodel)
        {
            if (ModelState.IsValid)
            {
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

                        var path = Path.Combine(Server.MapPath("~/App_Data/Upload/"), imageDetail.id + imageDetail.extension);
                        file.SaveAs(path);
                    }
                }

                productviewmodel.images = imageDetails;
                _context.product.Add(productviewmodel.products);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("index");
        }
    }
}