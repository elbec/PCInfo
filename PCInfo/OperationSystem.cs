using System;
using System.Management;

namespace PCInfo
{
    public static class OperationSystem
    {
        private static ManagementObjectSearcher osSearcher = new ManagementObjectSearcher("Select * from Win32_OperatingSystem");
        public static void GetInfo()
        {
            Console.WriteLine("Operation System Properties:");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (ManagementBaseObject obj in osSearcher.Get())
            {
                Console.WriteLine("  Caption ............................... : {0}", obj.Caption());
                Console.WriteLine("  WindowsDirectory: ..................... : {0}", obj.WindowsDirectory());
                Console.WriteLine("  ProductType ........................... : {0}", obj.ProductType());
                Console.WriteLine("  SerialNumber .......................... : {0}", obj.SerialNumber());
                Console.WriteLine("  SystemDirectory ....................... : {0}", obj.SystemDirectory());
                Console.WriteLine("  CountryCode ........................... : {0}", obj.CountryCode());
                Console.WriteLine("  CurrentTimeZone ....................... : {0}", obj.CurrentTimeZone());
                Console.WriteLine("  EncryptionLevel........................ : {0}", obj.EncryptionLevel());
                Console.WriteLine("  OSType ................................ : {0}", obj.OSType());
                Console.WriteLine("  Version ............................... : {0}", obj.Version());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
