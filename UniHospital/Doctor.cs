using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor()
        {
            Name = "Jim Law";
            EmployeeNumber = 753;
            Salary = 90000;
            Paid = false;
            Specialty = "Anesthesiologist";
        }

        public override void PayEmployee()
        {
            Paid = true;
            Console.WriteLine("You've paid the Doctor!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public void PatientCare(Patient patient)
        {
            patient.Health = patient.Health + 5;
            Console.WriteLine("You've cared for the patient!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
        public void CheckBlood(Patient patient)
        {
            patient.BloodLevel = patient.BloodLevel - 2;
            Console.WriteLine("You've checked the blood of the patient!");
            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
