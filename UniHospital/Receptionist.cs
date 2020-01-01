using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Receptionist : Employee
    {
        public bool Phone { get; set; }

        public Receptionist()
        {
            Name = "Pam Beesley";
            EmployeeNumber = 115;
            Salary = 45000;
            Phone = false;
            Paid = false;
        }

        public override void PayEmployee()
        {
            Paid = true;
            Console.WriteLine("You've paid the Receptionist!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public void Call()
        {
            Phone = true;
            Console.WriteLine("The receptionist is on the phone!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
