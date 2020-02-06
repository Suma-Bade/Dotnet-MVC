using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage ="Please enter name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be in a crct format")]
        //[DisplayName("Name")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Please enter valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter DOB in crct format")]
        public DateTime DOB { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid format")]
        public string Mobileno { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="please select country")]
        public string Country { get; set; }
        [Required( ErrorMessage ="Please enter username")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Please enter password")]
        [RegularExpression("[a-zA-Z0-9]{7,9}",ErrorMessage ="Invalid password")]
        public string Pwd{ get; set; }


    }
}
