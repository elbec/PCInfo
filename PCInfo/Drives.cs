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
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (ManagementBaseObject drive in driveSearcher.Get())
            {
                Console.WriteLine("Name: " + drive.Name());
                Console.WriteLine("Status: " + drive.Status());
                Console.WriteLine("Caption: " + drive.Caption());
                Console.WriteLine("DeviceID: " + drive.DeviceID());
                Console.WriteLine("Model: " + drive.Model());
                Console.WriteLine("Interface: " + drive.InterfaceType());
                Console.WriteLine("Serial#: " + drive.SerialNumber());
                Console.WriteLine("DriveFormat " + drive.DriveFormat());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
