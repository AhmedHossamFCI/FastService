using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastService.prod.ViewModels;
using System.Web.Security;
using FastService.prod.Models;

namespace FastService.prod.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    
        public ActionResult Autherize(LoginVm userLoginModel)
        {
            FastServicesDM dm = new FastServicesDM();
            var userInfo = dm.Users.FirstOrDefault(u => u.Username == userLoginModel.Username && u.Password == userLoginModel.Password);
            if (userInfo == null)
            {
                return View("Index", userLoginModel);
            }
            else
            {
                Session["userId"] = userInfo.Id;
                return RedirectToAction("Index", "ClientAdmin");
            }
        }
    }
}
