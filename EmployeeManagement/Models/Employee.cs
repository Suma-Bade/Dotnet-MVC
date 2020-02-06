using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="length can be max 10")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)\\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid")]
        [DisplayName("Company mail")]
          [ValidateDomain(allowdomain:"cts.com")]
       [Remote(action:"IsEmailExist",controller:"Employee")]
        public string Email { get; set; }
        public Dept Dept{ get; set; }
        public Employee()
        {

        }
        public Employee(int id,string name,string email,Dept Dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = Dept;
        }


        
    }
}
