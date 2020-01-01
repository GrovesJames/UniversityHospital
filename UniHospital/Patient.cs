using System;
using System.Collections.Generic;
using System.Text;

namespace UniHospital
{
    class Patient
    {
        public int Health { get; set; }
        public int BloodLevel { get; set; }

        public Patient()
        {
            Health = 10;
            BloodLevel = 20;
        }
    }
}
