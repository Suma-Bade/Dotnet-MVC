using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HandsOnModelValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Pls enter ID")]
        [DisplayName("Employee id")]
        public int ID { get; set; }
        [Required(ErrorMessage ="Pls enter name")]
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="Name should be in a crct format")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="invalid email id")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid Mobile num")] 
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Username is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="Invalid")]
        public string Pwd { get; set; } 
        [Compare("Pwd",ErrorMessage ="Password mismatch")]
        public string Cpwd { get; set; }
    }
}
