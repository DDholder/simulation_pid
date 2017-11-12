using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulation_pid
{
    public partial class pid : UserControl
    {
        public pid()
        {
            InitializeComponent();
        }
        float kp, ki, kd;
        float num, output, set_num;
        float err = 0, err_last = 0;
        float pid_I;
        Physics phy = new Physics();
        public delegate void TrackBarSetValue(TrackBar bar, int num);
        public delegate void LabelSet(Label label, string str);
        private void Pid_Load(object sender, EventArgs e)
        {
            t.Elapsed += new System.Timers.ElapsedEventHandler(Run);
            t.AutoReset = true;
            t.Enabled = false;
        }
        public void Start()
        {
            t.Enabled = true;
            phy.t.Enabled = true;
        }
        public void Stop()
        {
            t.Enabled = false;
            phy.t.Enabled = false;
        }
        public void ReSet()
        {
            phy.t.Enabled = false;
            t.Enabled = false;
            phy.It.Restart();
            output = 0;
            phy.Power = 0;
            err = 0;
            err_last = 0;
            num = 0;
            pid_I = 0;
        }
        public System.Timers.Timer t = new System.Timers.Timer(10);

        public float Kp { get => kp; set => kp = value; }
        public float Ki { get => ki; set => ki = value; }
        public float Kd { get => kd; set => kd = value; }
        public float Num { get => num; set => num = value; }
        public float Output { get => output; set => output = value; }
        public float Set_num { get => set_num; set => set_num = value; }
        public Physics Phy { get => phy; set => phy = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            kp = float.Parse(textBox1.Text);
            ki = float.Parse(textBox2.Text);
            kd = float.Parse(textBox3.Text);
        }
        void Run(object source, System.Timers.ElapsedEventArgs e)
        {
            num = phy.It.Position;
            err = set_num - num;
            output = err * kp + pid_I * ki + (err - err_last) * kd;
            err_last = err;
            pid_I += err;
            if (pid_I > 1000) pid_I = 1000;
            if (pid_I < -1000) pid_I = -1000;
            if (output > 1000) output = 1000;
            if (output < -1000) output = -1000;
            phy.Power = output;
            SetTrackBar(trackBar1, (int)output + 2000);
            SetLable(label4, pid_I.ToString("0.000"));
        }
        void SetTrackBar(TrackBar bar, int num)
        {
            if (bar.InvokeRequired)
            {
                TrackBarSetValue ChangeBarHandler = SetTrackBar;
                bar.Invoke(ChangeBarHandler, new object[] { bar, num });
            }
            else
            {
                if (num >= bar.Minimum && num <= bar.Maximum)
                    bar.Value = num;
            }
        }
        void SetLable(Label label, string str)
        {
            if (label.InvokeRequired)
            {
                LabelSet labelHandler = SetLable;
                label.Invoke(labelHandler, new object[] { label, str });
            }
            else
            {
                label.Text = str;
            }
        }
    }
}
