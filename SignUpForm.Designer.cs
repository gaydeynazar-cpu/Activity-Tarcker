namespace login_tutorial
{
    partial class SignUpForm
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
            this.NewUsername = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(300, 145);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(236, 26);
            this.NewUsername.TabIndex = 0;
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(300, 196);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(236, 26);
            this.NewPassword.TabIndex = 1;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(300, 248);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(236, 26);
            this.ConfirmPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "confirm password";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(300, 327);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(175, 37);
            this.newAccountButton.TabIndex = 7;
            this.newAccountButton.Text = "create a new account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(23, 25);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 51);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewUsername);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewUsername;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button back_button;
    }
}