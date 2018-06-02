using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FastService.prod.Models;
using FastService.prod.ViewModels;

namespace FastService.prod.Controllers
{
    public class ClientAdminController : Controller
    {
        private readonly FastServicesDM _dm = new FastServicesDM();
        // test
        // GET: ClientAdmin
        public ActionResult Index(LastWorksVm lw)
        {
            var vm = new ViewWorkVm()
            {
                LastWorks = _dm.LastWorks.Where(a => a.IsDeleted == false).ToList(),
                LastWorksVm = lw
            };
            return View(vm);
        }

        // POST: ClientAdmin/Create
        [HttpPost]
        public ActionResult Create(int? id, ViewWorkVm viewWork)
        {

            if (ModelState.IsValid)
            {
                var extension = Path.GetExtension(viewWork.LastWorksVm.ImgFile.FileName);

                string fileName = viewWork.LastWorksVm.Clientname + extension;

                viewWork.LastWorksVm.ImgURL = "~/Assets/images/clients/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Assets/images/clients/"), fileName);
                viewWork.LastWorksVm.ImgFile.SaveAs(fileName);

                if (viewWork.LastWorksVm.Id <= 0)
                {
                    // TODO: Add insert logic here

                    _dm.LastWorks.Add(new LastWork()
                    {
                        Name = viewWork.LastWorksVm.Clientname,
                        Img = viewWork.LastWorksVm.ImgURL
                    });
                }
                else
                {
                    var editedRow = viewWork.LastWorksVm;
                    var oldRow = _dm.LastWorks.FirstOrDefault(a => a.Id == viewWork.LastWorksVm.Id);
                    if (oldRow == null)
                    {
                        return HttpNotFound();
                    }
                    oldRow.Name = editedRow.Clientname;
                    oldRow.Img = editedRow.ImgURL;
                }

                _dm.SaveChanges();

                return RedirectToAction("Index", viewWork.LastWorksVm);
            }

            return View("Index");

        }

        // GET: ClientAdmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LastWork lastWork = _dm.LastWorks.Find(id);
            if (lastWork == null)
            {
                return HttpNotFound();
            }
            var vm = new ViewWorkVm()
            {
                LastWorks = _dm.LastWorks.Where(a => a.IsDeleted == false).ToList(),
                LastWorksVm = new LastWorksVm()
                {
                    Id = lastWork.Id,
                    Clientname = lastWork.Name,
                    ImgURL = lastWork.Img
                }
            };

            return RedirectToAction("Index", vm.LastWorksVm);
        }

        // POST: ClientAdmin/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, ViewWorkVm viewWorkVm)
        //{
        //    if (ModelState.IsValid)
        //    {


        //        return RedirectToAction("Index", viewWorkVm.LastWorksVm);
        //    }

        //    return View("Index");
        //}

        // GET: ClientAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LastWork lastWork = _dm.LastWorks.Find(id);
            if (lastWork == null)
            {
                return HttpNotFound();
            }
            lastWork.IsDeleted = true;
            _dm.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
