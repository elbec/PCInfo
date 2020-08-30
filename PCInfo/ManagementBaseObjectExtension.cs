using System;
using System.Management;

namespace PCInfo
{
    public static class ManagementBaseObjectExtension
    {
        private static string notFound = "Not found!";
        static public string DeviceID(this ManagementBaseObject obj)
        {
            try
            {
                return obj["DeviceID"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }
        public static string ProcessorID(this ManagementBaseObject obj)
        {
            try
            {
                return obj["processorID"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Model(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Model"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string InterfaceType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["InterfaceType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string SerialNumber(this ManagementBaseObject obj)
        {
            try
            {
                return obj["SerialNumber"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Name(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Name"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Manufacturer(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Manufacturer"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Status(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Status"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string PrimaryBusType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["PrimaryBusType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Caption(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Caption"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string AdapterRAM(this ManagementBaseObject obj)
        {
            try
            {
                return obj["AdapterRAM"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string AdapterDACType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["AdapterDACType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Monochrome(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Monochrome"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string InstalledDisplayDrivers(this ManagementBaseObject obj)
        {
            try
            {
                return obj["InstalledDisplayDrivers"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string DriverVersion(this ManagementBaseObject obj)
        {
            try
            {
                return obj["DriverVersion"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string VideoProcessor(this ManagementBaseObject obj)
        {
            try
            {
                return obj["VideoProcessor"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string VideoArchitecture(this ManagementBaseObject obj)
        {
            try
            {
                return obj["VideoArchitecture"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string VideoMemoryType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["VideoMemoryType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string DriveFormat(this ManagementBaseObject obj)
        {
            try
            {
                return obj["DriveFormat"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string CurrentClockSpeed(this ManagementBaseObject obj)
        {
            try
            {
                return obj["CurrentClockSpeed"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string NumberOfCores(this ManagementBaseObject obj)
        {
            try
            {
                return obj["NumberOfCores"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string NumberOfEnabledCore(this ManagementBaseObject obj)
        {
            try
            {
                return obj["NumberOfEnabledCore"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string NumberOfLogicalProcessors(this ManagementBaseObject obj)
        {
            try
            {
                return obj["NumberOfLogicalProcessors"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Architecture(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Architecture"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Family(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Family"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string ProcessorType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["ProcessorType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Characteristics(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Characteristics"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string AddressWidth(this ManagementBaseObject obj)
        {
            try
            {
                return obj["AddressWidth"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string WindowsDirectory(this ManagementBaseObject obj)
        {
            try
            {
                return obj["WindowsDirectory"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string ProductType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["ProductType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string SystemDirectory(this ManagementBaseObject obj)
        {
            try
            {
                return obj["SystemDirectory"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }
        static public string CountryCode(this ManagementBaseObject obj)
        {
            try
            {
                return obj["CountryCode"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }
        static public string CurrentTimeZone(this ManagementBaseObject obj)
        {
            try
            {
                return obj["CurrentTimeZone"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }
        static public string EncryptionLevel(this ManagementBaseObject obj)
        {
            try
            {
                return obj["EncryptionLevel"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string OSType(this ManagementBaseObject obj)
        {
            try
            {
                return obj["OSType"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

        static public string Version(this ManagementBaseObject obj)
        {
            try
            {
                return obj["Version"].ToString();
            }
            catch (Exception)
            {
                return notFound;
            }
        }

    }
}
