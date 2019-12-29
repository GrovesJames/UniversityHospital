using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Database
    {
        public bool DatabaseOff { get; set; }

        public Database()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\nWelcome to University Hospital's Database!");
            Console.WriteLine("\nPress enter to explore info..\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");

            Console.ReadLine();
            Console.Clear();
        }

        public void BootUp()
        {

        }
    }
}
