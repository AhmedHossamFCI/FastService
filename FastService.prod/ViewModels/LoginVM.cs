using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FastService.prod.ViewModels
{
    public class LoginVm
    {

        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //public string ReturnURL { get; set; }

    }
}