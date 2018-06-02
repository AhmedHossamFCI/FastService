using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FastService.prod.Models;

namespace FastService.prod.ViewModels
{
    public class ViewWorkVm
    {
        public List<LastWork> LastWorks { get; set; }
        public LastWorksVm LastWorksVm { get; set; }
        
    }
}