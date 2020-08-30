using System;
using System.Management;

namespace PCInfo
{ 
    static class CentralProcessingUnit
    {
        private static ManagementObjectSearcher cpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_processor");

        public static void GetInfo()
        {
            Console.WriteLine("CPU Properties:");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            foreach (ManagementBaseObject cpu in cpuSearcher.Get())
            {
                Console.WriteLine("  Name .................................. : {0}", cpu.Name());
                Console.WriteLine("  Status ................................ : {0}", cpu.Status());
                Console.WriteLine("  Caption ............................... : {0}", cpu.Caption());
                Console.WriteLine("  DeviceID .............................. : {0}", cpu.DeviceID());
                Console.WriteLine("  ProcessorID ........................... : {0}", cpu.ProcessorID());
                Console.WriteLine("  SerialNumber .......................... : {0}", cpu.SerialNumber());
                Console.WriteLine("  Manufacturer .......................... : {0}", cpu.Manufacturer());
                Console.WriteLine("  CurrentClockSpeed ..................... : {0}", cpu.CurrentClockSpeed());
                Console.WriteLine("  NumberOfCores ......................... : {0}", cpu.NumberOfCores());
                Console.WriteLine("  NumberOfEnabledCore ................... : {0}", cpu.NumberOfEnabledCore());
                Console.WriteLine("  NumberOfLogicalProcessors ............. : {0}", cpu.NumberOfLogicalProcessors());
                Console.WriteLine("  Architecture .......................... : {0}", cpu.Architecture());
                Console.WriteLine("  Family ................................ : {0}", cpu.Family());
                Console.WriteLine("  ProcessorType ......................... : {0}", cpu.ProcessorType());
                Console.WriteLine("  Characteristics ....................... : {0}", cpu.Characteristics());
                Console.WriteLine("  AddressWidth .......................... : {0}", cpu.AddressWidth());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
