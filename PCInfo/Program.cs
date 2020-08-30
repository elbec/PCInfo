using System;

namespace PCInfo
{
    static class Program
    {
        static void Main(string[] args)
        {
            Motherboard.GetMotherBoardInfo();
            Drives.GetDrivesInfo();

            Console.Write("Any key to exit");
            Console.ReadKey();
        }
    }
}
