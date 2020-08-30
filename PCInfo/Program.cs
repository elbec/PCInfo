using System;
using System.Net;
using System.Net.NetworkInformation;

namespace PCInfo
{
    static class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo selectedKey;
            bool wrongKey = true;
            int choosenKey = 0;
            do
            {
                do
                {
                    HeaderInfo();
                    LoadMenu();
                    selectedKey = Console.ReadKey(true);
                    Console.Clear();
                    try
                    {
                        choosenKey = int.Parse(selectedKey.KeyChar.ToString());
                        if (choosenKey < 0 || choosenKey > 9)
                        {
                            wrongKey = true;
                        }
                        else
                        {
                            wrongKey = false;
                        }

                    }
                    catch (Exception)
                    {
                        wrongKey = true;
                    }
                } while (wrongKey);

                switch (choosenKey)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        OperationSystem.GetInfo();
                        Motherboard.GetInfo();
                        CentralProcessingUnit.GetInfo();
                        GraphicsProcessingUnit.GetInfo();
                        Drives.GetInfo();
                        SoundDevices.GetInfo();
                        NetworkInterfaces.GetInfo();
                        Printers.GetInto();
                        break;
                    case 2:
                        OperationSystem.GetInfo();
                        break;
                    case 3:
                        Motherboard.GetInfo();
                        break;
                    case 4:
                        CentralProcessingUnit.GetInfo();
                        break;
                    case 5:
                        GraphicsProcessingUnit.GetInfo();
                        break;
                    case 6:
                        Drives.GetInfo();
                        break;
                    case 7:
                        SoundDevices.GetInfo();
                        break;
                    case 8:
                        NetworkInterfaces.GetInfo();
                        break;
                    case 9:
                        Printers.GetInto();
                        break;
                }
                
                Console.WriteLine("Any key to go back...");
                Console.ReadKey();
                Console.Clear();
            } while (choosenKey != 0);
        }

        static void HeaderInfo()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine("INFORMATION FOR {0}.{1}     ", computerProperties.HostName, computerProperties.DomainName);
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
        }

        static void LoadMenu()
        {
            Console.WriteLine("  1 - All data");
            Console.WriteLine("  2 - Operation System");
            Console.WriteLine("  3 - Motherboard");
            Console.WriteLine("  4 - Central Processing Unit");
            Console.WriteLine("  5 - Graphics Processing Unit");
            Console.WriteLine("  6 - Drives");
            Console.WriteLine("  7 - Sound Devices");
            Console.WriteLine("  8 - Netzwork Interfaces");
            Console.WriteLine("  9 - Printers");
            Console.WriteLine("  0 - Exit");
            Console.WriteLine();
            Console.WriteLine("Choose a number");
        }
    }
}
