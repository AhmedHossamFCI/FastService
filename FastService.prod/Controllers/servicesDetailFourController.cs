﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FastService.prod.Controllers
{
    public class servicesDetailFourController : Controller
    {
        // GET: servicesDetailFour
        public ActionResult Index()
        {
            return View();
        }

        // GET: servicesDetailFour/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: servicesDetailFour/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: servicesDetailFour/Create
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

        // GET: servicesDetailFour/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: servicesDetailFour/Edit/5
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

        // GET: servicesDetailFour/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: servicesDetailFour/Delete/5
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
