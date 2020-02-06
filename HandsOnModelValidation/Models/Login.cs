using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsOnModelValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage ="User name is required")]
        [DisplayName("Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [DisplayName("Password")]
        public string Pwd { get; set; }

    }
}
