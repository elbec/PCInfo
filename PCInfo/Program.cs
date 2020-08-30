using System;
using System.Net.NetworkInformation;

namespace PCInfo
{
    static class Program
    {
        static void Main(string[] args)
        {
            HeaderInfo();
            OperationSystem.GetInfo();
            Motherboard.GetInfo();
            CentralProcessingUnit.GetInfo();
            GraphicsProcessingUnit.GetInfo();
            Drives.GetInfo();
            NetworkInterfaces.GetInfo();
            
            Console.Write("Any key to exit");
            Console.ReadKey();
        }

        static void HeaderInfo()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("INFORMATION FOR {0}.{1}     ", computerProperties.HostName, computerProperties.DomainName);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
