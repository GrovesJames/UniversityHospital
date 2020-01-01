using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Nurse : Employee
    {
        public int PatientNumber { get; set; }

        public Nurse()
        {
            Name = "Sam Li";
            EmployeeNumber = 223;
            Salary = 50000;
            Paid = false;
            PatientNumber = 1;
        }

        public override void PayEmployee()
        {
            Paid = true;
            Console.WriteLine("You've paid the Nurse!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public void PatientCare(Patient patient)
        {
            patient.Health++;
            Console.WriteLine("You've cared for the patient!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public void CheckBlood(Patient patient)
        {
            patient.BloodLevel--;
            Console.WriteLine("You've checked the blood of the patient!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
