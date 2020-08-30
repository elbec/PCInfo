using System;
using System.Management;

namespace PCInfo
{
    class Drives
    {
        private static ManagementObjectSearcher driveSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
        
        public static void GetDrivesInfo()
        {
            Console.WriteLine("Drives Properties:");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (ManagementBaseObject drive in driveSearcher.Get())
            {
                Console.WriteLine("DeviceID: " + drive.DeviceID());
                Console.WriteLine("Model: " + drive.Model());
                Console.WriteLine("Interface: " + drive.InterfaceType());
                Console.WriteLine("Serial#: " + drive.SerialNumber());
                Console.WriteLine("Letter:" + drive.Name());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    public static class DrivesExtensions {
        private static string notFound = "Not found!";
        static public string DeviceID(this ManagementBaseObject drive)
        {
                try
                {
                    return drive["DeviceID"].ToString();
                }
                catch (Exception)
                {
                    return notFound;
                }
        }

        static public string Model(this ManagementBaseObject drive)
        {
            try
            {
                return drive["Model"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string InterfaceType(this ManagementBaseObject drive)
        {
            try
            {
                return drive["InterfaceType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string SerialNumber(this ManagementBaseObject drive)
        {
            try
            {
                return drive["SerialNumber"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Name(this ManagementBaseObject drive)
        {
            try
            {
                return drive["Name"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }
}
}
