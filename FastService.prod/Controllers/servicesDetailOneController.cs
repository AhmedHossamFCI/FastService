using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastService.prod.Controllers
{
    public class servicesDetailOneController : Controller
    {
        // GET: servicesDetailOne
        public ActionResult Index()
        {
            return View();
        }

        // GET: servicesDetailOne/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: servicesDetailOne/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: servicesDetailOne/Create
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

        // GET: servicesDetailOne/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: servicesDetailOne/Edit/5
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

        // GET: servicesDetailOne/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: servicesDetailOne/Delete/5
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
