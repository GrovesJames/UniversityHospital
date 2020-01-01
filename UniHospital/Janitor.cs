using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Janitor : Employee
    {
        public bool Sweeping { get; set; }

        public Janitor()
        {
            Name = "Ed Shaw";
            EmployeeNumber = 553;
            Salary = 40000;
            Paid = false;
        }

        public override void PayEmployee()
        {
            Paid = true;
            Console.WriteLine("You've paid the Janitor!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public void Sweep()
        {
            Sweeping = true;
            Console.WriteLine("The janitor is sweeping");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
