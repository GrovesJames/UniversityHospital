using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Database
    {
        public bool DatabaseOff { get; set; }
        Janitor janitor = new Janitor();
        Receptionist receptionist = new Receptionist();
        Nurse nurse = new Nurse();
        Doctor doctor = new Doctor();
        Patient patient = new Patient();

        public Database()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\nWelcome to University Hospital's Database!");
            Console.WriteLine("\nPress enter to explore info..\n");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadLine();
        }

        public void BootUp()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Select an option below:\n");
            Console.WriteLine("[A] View employee info in the University Database");
            Console.WriteLine("[B] Pay an employee");
            Console.WriteLine("[C] Have an employee perform a task\n");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            string startUpresponse = Console.ReadLine().ToLower();

            if (startUpresponse == "a")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(" Name | Occupation | Employee # | Salary | Paid Status |  Busy  |");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n" + doctor.Name + "  | " + doctor.Specialty + "  | " + doctor.EmployeeNumber + "  | " + doctor.Salary + "  | " + doctor.Paid);
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n" + nurse.Name + "  | Nurse  | " + nurse.EmployeeNumber + "  | " + nurse.Salary + "  | " + nurse.Paid);
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n" + receptionist.Name + "  | Receptionist  | " + receptionist.EmployeeNumber + "  | " + receptionist.Salary + "  | " + receptionist.Paid);
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n" + janitor.Name + "  | Janitor  | " + janitor.EmployeeNumber + "  | " + janitor.Salary + "  | " + janitor.Paid);
                Console.WriteLine("\n------------------------------------------------------------");
                Console.WriteLine("\nPress enter to continue..");
                Console.ReadLine();
            }
            else if (startUpresponse == "b")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------\n");
                Console.WriteLine("Choose an employee to pay:");
                Console.WriteLine("[A] " + doctor.Name);
                Console.WriteLine("[B] " + nurse.Name);
                Console.WriteLine("[C] " + receptionist.Name);
                Console.WriteLine("[D] " + janitor.Name + "\n");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------\n");
                string payMenu = Console.ReadLine().ToLower();

                if (payMenu == "a")
                {
                    doctor.PayEmployee();
                }
                else if (payMenu == "b")
                {
                    nurse.PayEmployee();
                }
                else if (payMenu == "c")
                {
                    receptionist.PayEmployee();
                }
                else if (payMenu == "d")
                {
                    janitor.PayEmployee();
                }
                else
                {
                    Console.WriteLine("error... retry");
                    Console.ReadLine();
                }
            }
            else if (startUpresponse == "c")
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------\n");
                Console.WriteLine("Choose an task for an employee to complete:");
                Console.WriteLine("[A] Doctor care for patient");
                Console.WriteLine("[B] Doctor checks blood of patient\n");
                Console.WriteLine("[C] Nurse cares for patient");
                Console.WriteLine("[D] Nurse checks blood of patient\n");
                Console.WriteLine("[E] Receptionist takes phone calls");
                Console.WriteLine("[F] Janitor sweeps building\n");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------------------------------------------------------\n");
                string actionMenu = Console.ReadLine().ToLower();

                if (actionMenu == "a")
                {
                    doctor.PatientCare(patient);
                }
                else if (actionMenu == "b")
                {
                    doctor.CheckBlood(patient);
                }
                else if (actionMenu == "c")
                {
                    nurse.PatientCare(patient);
                }
                else if (actionMenu == "d")
                {
                    nurse.CheckBlood(patient);
                }
                else if (actionMenu == "e")
                {
                    receptionist.Call();
                }
                else if (actionMenu == "f")
                {
                    janitor.Sweep();
                }
                else
                {
                    Console.WriteLine("error... retry");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("error... retry");
            }
        }
    }
}
