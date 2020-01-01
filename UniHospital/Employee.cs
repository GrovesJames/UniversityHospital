using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        public virtual void PayEmployee()
        {

        }
    }
}
