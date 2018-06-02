using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastService.prod.Controllers
{
    public class contactusController : Controller
    {
        // GET: contactus
        public ActionResult Index()
        {
            return View();
        }

        // GET: contactus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: contactus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: contactus/Create
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

        // GET: contactus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: contactus/Edit/5
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

        // GET: contactus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: contactus/Delete/5
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
