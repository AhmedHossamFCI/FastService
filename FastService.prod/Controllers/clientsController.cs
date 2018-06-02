using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastService.prod.Models;
using FastService.prod.ViewModels;

namespace FastService.prod.Controllers
{
    public class clientsController : Controller
    {
        FastServicesDM _dm = new FastServicesDM();
        // GET: clients
        public ActionResult Index()
        {
            var clientList = _dm.LastWorks.Where(l => l.IsDeleted == false).ToList();
            var clientVm = new List<ViewClientsVm>();

            foreach (var client in clientList)
            {
                clientVm.Add(new ViewClientsVm()
                {
                    clientName = client.Name,
                    imgUrl = client.Img
                });
            }

            return View(clientVm);
        }

        // GET: clients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: clients/Create
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

        // GET: clients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: clients/Edit/5
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

        // GET: clients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: clients/Delete/5
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
