using System;
using System.Management;

namespace PCInfo
{   
    public static class Drives
    {
        private static ManagementObjectSearcher driveSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
        
        public static void GetInfo()
        {
            Console.WriteLine("Drives Properties:");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            foreach (ManagementBaseObject drive in driveSearcher.Get())
            {
                Console.WriteLine("  Name .................................. : {0}", drive.Name());
                Console.WriteLine("  Status ................................ : {0}", drive.Status());
                Console.WriteLine("  Caption ............................... : {0}", drive.Caption());
                Console.WriteLine("  DeviceID .............................. : {0}", drive.DeviceID());
                Console.WriteLine("  Model ................................. : {0}", drive.Model());
                Console.WriteLine("  Interface ............................. : {0}", drive.InterfaceType());
                Console.WriteLine("  SerialNumber .......................... : {0}", drive.SerialNumber());
                Console.WriteLine("  DriveFormat ........................... : {0}", drive.DriveFormat());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
