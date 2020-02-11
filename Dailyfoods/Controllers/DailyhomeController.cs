using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dailyfoods.Controllers
{
    public class DailyhomeController : Controller
    {
        // GET: Dailyhome
        public ActionResult DailyFoodIndex()
        {
            return View();
        }

        // GET: Dailyhome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dailyhome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dailyhome/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dailyhome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dailyhome/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dailyhome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dailyhome/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
