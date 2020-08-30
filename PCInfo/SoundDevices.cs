using System;
using System.Management;

namespace PCInfo
{
    public static class SoundDevices
    {
        private static ManagementObjectSearcher myAudioObject = new ManagementObjectSearcher("select * from Win32_SoundDevice");
        public static void GetInfo()
        {
            Console.WriteLine("Sound Devices Properties:");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            foreach (ManagementBaseObject obj in myAudioObject.Get())
            {
                Console.WriteLine(obj.Name());
                Console.WriteLine(String.Empty.PadLeft(obj.ProductName().ToString().Length, '='));
                Console.WriteLine("  ProductName ........................... : {0}", obj.ProductName());
                Console.WriteLine("  Availability .......................... : {0}", obj["Availability"]);
                Console.WriteLine("  DeviceID .............................. : {0}", obj.DeviceID());
                Console.WriteLine("  PowerManagementSupported .............. : {0}", obj["PowerManagementSupported"]);
                Console.WriteLine("  Status ................................ : {0}", obj.Status());
                Console.WriteLine("  StatusInfo ............................ : {0}", obj["StatusInfo"]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
     
    }
}
