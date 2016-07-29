using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            label3.Text = i.OSFullName + ", v" + i.OSVersion + ", " + i.OSPlatform + ", " + (i.TotalPhysicalMemory / 1024) / 1024 / 1024 + "GB RAM"; 
        }
    }
}
