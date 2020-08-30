using System;
using System.Management;

namespace PCInfo
{
    public static class Printers
    {
        private static ManagementObjectSearcher myPrinterObject = new ManagementObjectSearcher("select * from Win32_Printer");
        public static void GetInto()
        {
            Console.WriteLine("Printers Properties:");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            foreach (ManagementBaseObject obj in myPrinterObject.Get())
            {
                Console.WriteLine(obj.Name());
                Console.WriteLine(String.Empty.PadLeft(obj["Name"].ToString().Length, '='));
                Console.WriteLine("  Network ............................... : {0}", obj["Network"]);
                Console.WriteLine("  Availability .......................... : {0}", obj["Availability"]);
                Console.WriteLine("  Is default printer .................... : {0}", obj["Default"]);
                Console.WriteLine("  DeviceID .............................. : {0}", obj.DeviceID());
                Console.WriteLine("  Status ................................ : {0}", obj.Status());

                
            }
            Console.WriteLine();
            Console.WriteLine();
        }
}
}
