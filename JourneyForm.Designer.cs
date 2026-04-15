namespace login_tutorial
{
    partial class JourneyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Distance = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Start_Journey = new System.Windows.Forms.Button();
            this.journeyTimer = new System.Windows.Forms.Timer(this.components);
            this.total_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pause_Journey = new System.Windows.Forms.Button();
            this.Resume_Journey = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(682, 356);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(18, 20);
            this.Distance.TabIndex = 0;
            this.Distance.Text = "0";
            this.Distance.Click += new System.EventHandler(this.Distance_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(682, 397);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(18, 20);
            this.Time.TabIndex = 1;
            this.Time.Text = "0";
            this.Time.Click += new System.EventHandler(this.ShowLat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Distance (metres):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time (seconds):";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 356);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(150, 61);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop Journey";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start_Journey
            // 
            this.Start_Journey.Location = new System.Drawing.Point(193, 356);
            this.Start_Journey.Name = "Start_Journey";
            this.Start_Journey.Size = new System.Drawing.Size(150, 61);
            this.Start_Journey.TabIndex = 6;
            this.Start_Journey.Text = "Start Journey";
            this.Start_Journey.UseVisualStyleBackColor = true;
            this.Start_Journey.Click += new System.EventHandler(this.Start_Click);
            // 
            // journeyTimer
            // 
            this.journeyTimer.Tick += new System.EventHandler(this.journeyTimer_Tick);
            // 
            // total_timer
            // 
            this.total_timer.Interval = 1000;
            this.total_timer.Tick += new System.EventHandler(this.total_timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 335);
            this.panel1.TabIndex = 7;
            // 
            // Pause_Journey
            // 
            this.Pause_Journey.Location = new System.Drawing.Point(193, 356);
            this.Pause_Journey.Name = "Pause_Journey";
            this.Pause_Journey.Size = new System.Drawing.Size(150, 61);
            this.Pause_Journey.TabIndex = 0;
            this.Pause_Journey.Text = "pause";
            this.Pause_Journey.UseVisualStyleBackColor = true;
            this.Pause_Journey.Click += new System.EventHandler(this.Pause_Journey_Click);
            // 
            // Resume_Journey
            // 
            this.Resume_Journey.Location = new System.Drawing.Point(193, 356);
            this.Resume_Journey.Name = "Resume_Journey";
            this.Resume_Journey.Size = new System.Drawing.Size(150, 61);
            this.Resume_Journey.TabIndex = 8;
            this.Resume_Journey.Text = "Resume";
            this.Resume_Journey.UseVisualStyleBackColor = true;
            this.Resume_Journey.Click += new System.EventHandler(this.Resume_Journey_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(386, 356);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(117, 60);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // JourneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Resume_Journey);
            this.Controls.Add(this.Pause_Journey);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Start_Journey);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Distance);
            this.Name = "JourneyForm";
            this.Text = "JourneyForm";
            this.Load += new System.EventHandler(this.JourneyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start_Journey;
        private System.Windows.Forms.Timer journeyTimer;
        private System.Windows.Forms.Timer total_timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Pause_Journey;
        private System.Windows.Forms.Button Resume_Journey;
        private System.Windows.Forms.Button back_button;
    }
}