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
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (ManagementBaseObject gpu in gpuSearcher.Get())
            {
                Console.WriteLine("Name: " + gpu.Name());
                Console.WriteLine("Status: " + gpu.Status());
                Console.WriteLine("Caption: " + gpu.Caption());
                Console.WriteLine("DeviceID: " + gpu.DeviceID());
                Console.WriteLine("AdapterRAM: " + gpu.AdapterRAM());
                Console.WriteLine("AdapterDACType: " + gpu.AdapterDACType());
                Console.WriteLine("Monochrome: " + gpu.Monochrome());
                Console.WriteLine("InstalledDisplayDrivers: " + gpu.InstalledDisplayDrivers());
                Console.WriteLine("DriverVersion: " + gpu.DriverVersion());
                Console.WriteLine("VideoProcessor: " + gpu.VideoProcessor());
                Console.WriteLine("VideoArchitecture: " + gpu.VideoArchitecture());
                Console.WriteLine("VideoMemoryType: " + gpu.VideoMemoryType());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
