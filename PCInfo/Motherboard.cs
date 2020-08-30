using System;
using System.Management;

namespace PCInfo
{
    public static class Motherboard
    {
        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private static ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");
        private static string notFound = "Not found!";

        public static void GetInfo()
        {
            Console.WriteLine("Motherboard Properties:");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("  Availability .......................... : {0}", Motherboard.Availability);
            Console.WriteLine("  HostingBoard .......................... : {0}", Motherboard.HostingBoard);
            Console.WriteLine("  InstallDate ........................... : {0}", Motherboard.InstallDate);
            Console.WriteLine("  Manufacturer .......................... : {0}", Motherboard.Manufacturer);
            Console.WriteLine("  Model: ................................ : {0}", Motherboard.Model);
            Console.WriteLine("  PartNumber ............................ : {0}", Motherboard.PartNumber);
            Console.WriteLine("  PNPDeviceID ........................... : {0}", Motherboard.PNPDeviceID);
            Console.WriteLine("  PrimaryBusType ........................ : {0}", Motherboard.PrimaryBusType);
            Console.WriteLine("  Product ............................... : {0}", Motherboard.Product);
            Console.WriteLine("  Removable ............................. : {0}", Motherboard.Removable);
            Console.WriteLine("  Replaceable ........................... : {0}", Motherboard.Replaceable);
            Console.WriteLine("  RevisionNumber ........................ : {0}", Motherboard.RevisionNumber);
            Console.WriteLine("  SecondaryBusType ...................... : {0}", Motherboard.SecondaryBusType);
            Console.WriteLine("  SerialNumber .......................... : {0}", Motherboard.SerialNumber);
            Console.WriteLine("  Status ................................ : {0}", Motherboard.Status);
            Console.WriteLine("  SystemName ............................ : {0}", Motherboard.SystemName);
            Console.WriteLine("  Version ............................... : {0}", Motherboard.Version);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static public string Availability
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in motherboardSearcher.Get())
                    {
                        return GetAvailability(int.Parse(queryObj["Availability"].ToString()));
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public bool HostingBoard
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        if (queryObj["HostingBoard"].ToString() == "True")
                            return true;
                        else
                            return false;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        static public string InstallDate
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return ConvertToDateTime(queryObj["InstallDate"].ToString());
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string Manufacturer
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Manufacturer"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }


        static public string Model
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Model"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string PartNumber
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["PartNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string PNPDeviceID
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["PNPDeviceID"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string PrimaryBusType
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["PrimaryBusType"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string Product
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Product"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public bool Removable
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        if (queryObj["Removable"].ToString() == "True")
                            return true;
                        else
                            return false;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        static public bool Replaceable
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        if (queryObj["Replaceable"].ToString() == "True")
                            return true;
                        else
                            return false;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        static public string RevisionNumber
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["RevisionNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string SecondaryBusType
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["SecondaryBusType"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string SerialNumber
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["SerialNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string Status
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject querObj in baseboardSearcher.Get())
                    {
                        return querObj["Status"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string SystemName
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["SystemName"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        static public string Version
        {
            get
            {
                try
                {
                    foreach (ManagementBaseObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Version"].ToString();
                    }
                    return "";
                }
                catch (Exception)
                {
                    return notFound;
                }
            }
        }

        private static string GetAvailability(int availability)
        {
            switch (availability)
            {
                case 1: return "Other";
                case 2: return "Unknown";
                case 3: return "Running or Full Power";
                case 4: return "Warning";
                case 5: return "In Test";
                case 6: return "Not Applicable";
                case 7: return "Power Off";
                case 8: return "Off Line";
                case 9: return "Off Duty";
                case 10: return "Degraded";
                case 11: return "Not Installed";
                case 12: return "Install Error";
                case 13: return "Power Save - Unknown";
                case 14: return "Power Save - Low Power Mode";
                case 15: return "Power Save - Standby";
                case 16: return "Power Cycle";
                case 17: return "Power Save - Warning";
                default: return "Unknown";
            }
        }

        private static string ConvertToDateTime(string unconvertedTime)
        {
            string convertedTime = "";
            int year = int.Parse(unconvertedTime.Substring(0, 4));
            int month = int.Parse(unconvertedTime.Substring(4, 2));
            int date = int.Parse(unconvertedTime.Substring(6, 2));
            int hours = int.Parse(unconvertedTime.Substring(8, 2));
            int minutes = int.Parse(unconvertedTime.Substring(10, 2));
            int seconds = int.Parse(unconvertedTime.Substring(12, 2));
            string meridian = "AM";
            if (hours > 12)
            {
                hours -= 12;
                meridian = "PM";
            }
            convertedTime = date.ToString() + "/" + month.ToString() + "/" + year.ToString() + " " +
            hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString() + " " + meridian;
            return convertedTime;
        }
    }
}
