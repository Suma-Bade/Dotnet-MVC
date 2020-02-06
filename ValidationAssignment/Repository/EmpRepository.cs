using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValidationAssignment.Models;

namespace ValidationAssignment.Repository
{
    public class EmpRepository
    {
        public static List<Employee> elist = new List<Employee>(){new Employee()
         {
                EID=845163,
                Name="Suma",
                Designation="FSE",
                Password="123456"
            }


        };
        public EmpRepository()
        {

        }
        public void Add(Employee emp)
        {
            elist.Add(emp);
        }
        public Employee Validate(int eid,string pwd)
        {
            foreach (var emp in elist)
            {
                if (emp.EID == eid && emp.Password == pwd)
                {
                    return emp;
                }
            }
            return null;
        }
    }
}

    

