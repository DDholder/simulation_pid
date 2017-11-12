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
    public partial class Item : UserControl
    {
        float speed = 0, acceleration = 0, mass = 0, position = 0;
        float friction_static = 0, friction_move = 0;
        public Item()
        {
            InitializeComponent();
            speed = 0; acceleration = 0; position = 0;
            friction_static = float.Parse(textBox2.Text);
            friction_move = float.Parse(textBox3.Text);
            mass = float.Parse(textBox1.Text);
        }

        public float Speed { get => speed; set => speed = value; }
        public float Acceleration { get => acceleration; set => acceleration = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            mass = float.Parse(textBox1.Text);
            friction_static = float.Parse(textBox2.Text);
            friction_move = float.Parse(textBox3.Text);
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
        public void Restart()
        {
            speed = 0; acceleration = 0;  position = 0;
        }
        public float Mass { get => mass; set => mass = value; }
        public float Friction_static { get => friction_static; set => friction_static = value; }
        public float Friction_move { get => friction_move; set => friction_move = value; }
        public float Position { get => position; set => position = value; }
    }
}
