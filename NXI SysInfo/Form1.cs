using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NXI.MathLib;

namespace NXI_SysInfo
{
    public partial class Form1 : Form
    {

        public Microsoft.VisualBasic.Devices.ComputerInfo i = new Microsoft.VisualBasic.Devices.ComputerInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            
        {
            ulong totalRamMemory = NXI.MathLib.Math.BytesToGbUlong(i.TotalPhysicalMemory);
            string totalRamMemoryStr = NXI.MathLib.Math.FormatULong(totalRamMemory, "##, ###, ###");
            label3.Text = i.OSFullName + ", v" + i.OSVersion + ", " + i.OSPlatform + ", " + totalRamMemoryStr  + "GB RAM";

            label10.Text = W32Mng.CPU.getCPUName();
            label11.Text = "max.: " + W32Mng.CPU.getCpuMaxClockSpeed() + " MHz, currently: " +  W32Mng.CPU.getCpuCurrentClockSpeed(); 
        }
    }
}
