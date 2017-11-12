namespace simulation_pid
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.item1 = new simulation_pid.Item();
            this.physics1 = new simulation_pid.Physics();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pid1 = new simulation_pid.pid();
            this.SuspendLayout();
            // 
            // item1
            // 
            this.item1.Acceleration = 0F;
            this.item1.Friction_move = 0F;
            this.item1.Friction_static = 0F;
            this.item1.Location = new System.Drawing.Point(671, 37);
            this.item1.Mass = 0F;
            this.item1.Name = "item1";
            this.item1.Position = 0F;
            this.item1.Size = new System.Drawing.Size(242, 266);
            this.item1.Speed = 0F;
            this.item1.TabIndex = 0;
            // 
            // physics1
            // 
            this.physics1.Location = new System.Drawing.Point(111, 253);
            this.physics1.Name = "physics1";
            this.physics1.Power = 0F;
            this.physics1.Size = new System.Drawing.Size(578, 329);
            this.physics1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pid1
            // 
            this.pid1.Kd = 0F;
            this.pid1.Ki = 0F;
            this.pid1.Kp = 0F;
            this.pid1.Location = new System.Drawing.Point(111, 23);
            this.pid1.Name = "pid1";
            this.pid1.Num = 0F;
            this.pid1.Output = 0F;
            this.pid1.Set_num = 0F;
            this.pid1.Size = new System.Drawing.Size(210, 144);
            this.pid1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 581);
            this.Controls.Add(this.pid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.physics1);
            this.Controls.Add(this.item1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Item item1;
        private Physics physics1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private pid pid1;
    }
}

