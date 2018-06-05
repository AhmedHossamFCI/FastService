using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using FastService.prod.ViewModels;

namespace FastService.prod.Controllers
{
    public class ContactusController : Controller
    {
        // GET: contactus
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactVm vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(vm.Email);
                    mailMessage.To.Add("emailaddrss@gmail.com");//for testing :D 
                    mailMessage.Subject = " Name: " + vm.Name + "Phone 1: " + vm.Phone1 + "Phone 2: " + vm.Phone2;
                    mailMessage.Body = vm.Message;
                    SmtpClient smtpClient = new SmtpClient()
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential("YourMail@gmail.com","YourPassword"),
                        EnableSsl = true
                    };
                    smtpClient.Send(mailMessage);
                    ModelState.Clear();
                    //ViewBag.Message = "Thank you for contacting us";

                }
                catch (Exception e)
                {
                    ModelState.Clear();
                    //ViewBag.Message = $"Sorry we are facing problem here {e.Message}";
                }
            }

            return View();
        }

    }
}
