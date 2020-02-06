using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public List<Employee> emplist;
        public EmployeeRepository()
        {
            emplist = new List<Employee>() { new Employee(1,"josh","js123@gmail.com",Dept.HealthCare),
                                           new Employee(2,"joshi","joshi123@gmail.com",Dept.Insurance),
            new Employee(3,"jai","jai123@gmail.com",Dept.Insurance),
            
            new Employee(4, "suma", "suma123@cts.com", Dept.Insurance)
            };
        }
        public Employee GetEmployee(int id)
        {
            Employee e = emplist.FirstOrDefault(e => e.Id == id);
            return e;
        }
        public List<Employee> DisplayDetails()
        {
            return emplist;
        }
        public bool AddEmployee(Employee employee)
        {
            employee.Id = emplist.Max(e => e.Id) + 1;
            emplist.Add(employee);
            return true;
        }
            
    }
}
