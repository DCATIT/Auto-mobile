using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace AUTOPARTS.CONNECTION
{
    public class REGISTRYVALUES
    {


        public static string getValue(string L)
        {
            string path = "";
            RegistryKey localKey ;

            try
            {
                if (Environment.Is64BitOperatingSystem)
                {
                    localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
                }
                else
                {
                    localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32);
                }

                localKey = localKey.OpenSubKey(@"SOFTWARE\DAT");

                if(localKey != null)
                {
                    
                    if (L == "N")
                    {
                        path = localKey.GetValue("DBNAME").ToString();
                        Console.WriteLine("DATABASE NAME " + path);
                    }
                    else if (L == "P")
                    {
                        path = localKey.GetValue("DBPW").ToString();
                        Console.WriteLine("DATABASE PASSWORD " + path);                    }
                    else if (L == "S")
                    {
                        path = localKey.GetValue("DBSERVER").ToString();
                        Console.WriteLine("DATABASE SERVER " + path);
                    }
                    else if (L == "LN")
                    {
                        path = localKey.GetValue("DBLNAME").ToString();
                        Console.WriteLine("LOCAL DATABASE NAME " + path);
                    }
                    else if (L == "LP")
                    {
                        path = localKey.GetValue("DBLPW").ToString();
                        Console.WriteLine("LOCAL DATABASE PASSWORD " + path);
                    }
                    else if (L == "LS")
                    {
                        path = localKey.GetValue("DBLOCAL").ToString();
                        Console.WriteLine("LOCAL SERVER " + path);
                    }

                }
                    //localKey.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return path;
        }

    }
}
