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
            private static string CPUMaxClockSpeed;

            public static string getCPUName()
            {
                using (ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor"))
                

                    foreach (ManagementObject o in win32Proc.Get())
                    {
                        CPUName = o["Name"].ToString();
                    }
                {
 
                }

                return CPUName;
            }

            public static string getCpuMaxClockSpeed()
            {
                using (ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor"))


                    foreach (ManagementObject o in win32Proc.Get())
                    {
                        CPUMaxClockSpeed = o["MaxClockSpeed"].ToString();
                    }
                {

                }

                return CPUMaxClockSpeed;
            }
        }
    }
}
