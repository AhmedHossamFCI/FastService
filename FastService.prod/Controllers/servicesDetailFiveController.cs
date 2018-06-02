using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastService.prod.Controllers
{
    public class servicesDetailFiveController : Controller
    {
        // GET: servicesDetailFive
        public ActionResult Index()
        {
            return View();
        }

        // GET: servicesDetailFive/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: servicesDetailFive/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: servicesDetailFive/Create
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

        // GET: servicesDetailFive/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: servicesDetailFive/Edit/5
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

        // GET: servicesDetailFive/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: servicesDetailFive/Delete/5
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
