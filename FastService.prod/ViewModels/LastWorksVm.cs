using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FastService.prod.Models;

namespace FastService.prod.ViewModels
{
    public class LastWorksVm
    {
        public int Id { get; set; }
        public string Clientname { get; set; }
        public string ImgURL { get; set; }
        public HttpPostedFileBase ImgFile { get; set; }
    }
}