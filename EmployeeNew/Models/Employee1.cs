using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EmployeeNew.Models
{
    public enum department
    {
        IT,Accounts,Insurance,Healthcare
    }
    public class Employee1
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public department Dept { get; set; }

    }
}
