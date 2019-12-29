using System;

namespace UniHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            bool databaseOn = true;
            while (databaseOn)
            {
                Database db = new Database();

                while (db.DatabaseOff == false)
                {
                    db.BootUp();
                }
                databaseOn = false;
            }
        }
    }
}
