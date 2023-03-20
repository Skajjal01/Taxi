using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas1
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Drivername: {0}", DriverName);
            Console.WriteLine("OnDuty: {0}", OnDuty ? "ya" : "tidak");
            Console.WriteLine("NumPassenger: {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang perjalanan menjemput anda\n", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} telah mengantar anda\n", DriverName);
        }
    }
}
