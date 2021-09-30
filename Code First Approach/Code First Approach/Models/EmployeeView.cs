using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First_Approach.Models
{
    public class EmployeeView
    {
        public List<Employee> getData()
        {
            EmployeeContext ec = new EmployeeContext();
            var emp = ec.Employees.ToList();
            return emp;
        }
    }
}