using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation_pid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pid1.ReSet();
            pid1.Set_num = 5000;
            pid1.Start();
            //timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            physics1.It = item1;
            pid1.Phy = physics1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            physics1.Power = 0;
            timer1.Enabled = false;
        }
    }
}
