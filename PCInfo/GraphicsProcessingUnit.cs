using System;
using System.Management;

namespace PCInfo
{
    public static class GraphicsProcessingUnit
    {
        private static ManagementObjectSearcher gpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

        public static void GetInfo()
        {
            Console.WriteLine("GPU Properties:");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            foreach (ManagementBaseObject gpu in gpuSearcher.Get())
            {
                Console.WriteLine("  Name .................................. : {0}", gpu.Name());
                Console.WriteLine("  Status ................................ : {0}", gpu.Status());
                Console.WriteLine("  Caption ............................... : {0}", gpu.Caption());
                Console.WriteLine("  DeviceID .............................. : {0}", gpu.DeviceID());
                Console.WriteLine("  AdapterRAM ............................ : {0}", gpu.AdapterRAM());
                Console.WriteLine("  AdapterDACType ........................ : {0}", gpu.AdapterDACType());
                Console.WriteLine("  Monochrome ............................ : {0}", gpu.Monochrome());
                Console.WriteLine("  InstalledDisplayDrivers ............... : {0}", gpu.InstalledDisplayDrivers());
                Console.WriteLine("  DriverVersion ......................... : {0}", gpu.DriverVersion());
                Console.WriteLine("  VideoProcessor ........................ : {0}", gpu.VideoProcessor());
                Console.WriteLine("  VideoArchitecture ..................... : {0}", gpu.VideoArchitecture());
                Console.WriteLine("  VideoMemoryType ....................... : {0}", gpu.VideoMemoryType());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
