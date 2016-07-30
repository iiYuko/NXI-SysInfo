using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace NXI_SysInfo
{
    class W32Mng
    {
        public class CPU
        {
            private static string CPUName;

            public static string getCPUName()
            {
                using (ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor"),
                win32CompSys = new ManagementObjectSearcher("select * from Win32_ComputerSystem"),
                win32Memory = new ManagementObjectSearcher("select * from Win32_PhysicalMemory"))
                

                    foreach (ManagementObject o in win32Proc.Get())
                    {
                        CPUName = o["Name"].ToString();
                    }
                {
 
                }

                return CPUName;
            }
        }
    }
}
