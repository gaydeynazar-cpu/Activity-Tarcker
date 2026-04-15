
namespace login_tutorial
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.JH_button = new System.Windows.Forms.Button();
            this.NameDisplay = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(258, 114);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(235, 51);
            this.start.TabIndex = 1;
            this.start.Text = "Start a journey";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Leader Board";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // JH_button
            // 
            this.JH_button.Location = new System.Drawing.Point(258, 322);
            this.JH_button.Name = "JH_button";
            this.JH_button.Size = new System.Drawing.Size(235, 51);
            this.JH_button.TabIndex = 3;
            this.JH_button.Text = "Journey History";
            this.JH_button.UseVisualStyleBackColor = true;
            this.JH_button.Click += new System.EventHandler(this.JH_button_Click);
            // 
            // NameDisplay
            // 
            this.NameDisplay.AutoSize = true;
            this.NameDisplay.Location = new System.Drawing.Point(737, 9);
            this.NameDisplay.Name = "NameDisplay";
            this.NameDisplay.Size = new System.Drawing.Size(51, 20);
            this.NameDisplay.TabIndex = 4;
            this.NameDisplay.Text = "label2";
            this.NameDisplay.Click += new System.EventHandler(this.UsersName_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(724, 32);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 33);
            this.logout_button.TabIndex = 5;
            this.logout_button.Text = "log out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(657, 394);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(131, 44);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "Delete Account";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.NameDisplay);
            this.Controls.Add(this.JH_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button JH_button;
        private System.Windows.Forms.Label NameDisplay;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button Delete_button;
    }
}