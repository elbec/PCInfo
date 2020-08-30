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
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (ManagementBaseObject cpu in cpuSearcher.Get())
            {
                Console.WriteLine("Name: " + cpu.Name());
                Console.WriteLine("Status: " + cpu.Status());
                Console.WriteLine("Caption: " + cpu.Caption());
                Console.WriteLine("DeviceID: " + cpu.DeviceID());
                Console.WriteLine("ProcessorID: " + cpu.ProcessorID());
                Console.WriteLine("SerialNumber: " + cpu.SerialNumber());
                Console.WriteLine("Manufacturer: " + cpu.Manufacturer());
                Console.WriteLine("CurrentClockSpeed: " + cpu.CurrentClockSpeed());
                Console.WriteLine("NumberOfCores: " + cpu.NumberOfCores());
                Console.WriteLine("NumberOfEnabledCore: " + cpu.NumberOfEnabledCore());
                Console.WriteLine("NumberOfLogicalProcessors: " + cpu.NumberOfLogicalProcessors());
                Console.WriteLine("Architecture: " + cpu.Architecture());
                Console.WriteLine("Family: " + cpu.Family());
                Console.WriteLine("ProcessorType: " + cpu.ProcessorType());
                Console.WriteLine("Characteristics: " + cpu.Characteristics());
                Console.WriteLine("AddressWidth: " + cpu.AddressWidth());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
