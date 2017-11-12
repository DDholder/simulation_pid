using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace simulation_pid
{
    public partial class Physics : UserControl
    {
        float power;
        public delegate void TrackBarSetValue(TrackBar bar, int num);
        public delegate void LabelSet(Label label, string str);
        Item it = new Item();
        public System.Timers.Timer t = new System.Timers.Timer(5);
        public Physics()
        {
            InitializeComponent();
        }

        public Item It { get => it; set => it = value; }
        public float Power { get => power; set => power = value; }
        void Run(object source, ElapsedEventArgs e)
        {
            if (it.Speed == 0)
                it.Acceleration = (power - it.Friction_static) > 0 ? (power - it.Friction_static) / it.Mass : 0;
            else
                it.Acceleration = it.Speed > 0 ? (power - it.Friction_move) / it.Mass : (power + it.Friction_move) / it.Mass;
            float temp = it.Speed;
            it.Speed += it.Acceleration;
            if (it.Speed * temp <= 0 && Math.Abs(power) < it.Friction_static)
            {
                it.Speed = 0;
                it.Acceleration = 0;
            }
            it.Position += it.Speed;
            SetTrackBar(trackBar1, (int)it.Position);
            SetTrackBar(trackBar2, 5000 + (int)it.Speed * 100);
            SetTrackBar(trackBar3, 5000 + (int)it.Acceleration * 1000);
            SetLable(label1, it.Position.ToString("0.00"));
            SetLable(label2, it.Speed.ToString("0.00"));
            SetLable(label3, it.Acceleration.ToString("0.00"));
        }

        private void Physics_Load(object sender, EventArgs e)
        {
            t.Elapsed += new ElapsedEventHandler(Run);
            t.AutoReset = true;
            t.Enabled = false;
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
