﻿namespace InventoTrack
{
    partial class LoginForm
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
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_sername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(22, 43);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(880, 26);
            this.textBox_Username.TabIndex = 0;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(22, 98);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(880, 26);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_sername
            // 
            this.textBox_sername.AutoSize = true;
            this.textBox_sername.Location = new System.Drawing.Point(18, 14);
            this.textBox_sername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textBox_sername.Name = "textBox_sername";
            this.textBox_sername.Size = new System.Drawing.Size(83, 20);
            this.textBox_sername.TabIndex = 2;
            this.textBox_sername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(26, 138);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(112, 35);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_backToMain
            // 
            this.button_backToMain.Location = new System.Drawing.Point(1966, 866);
            this.button_backToMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_backToMain.Name = "button_backToMain";
            this.button_backToMain.Size = new System.Drawing.Size(112, 35);
            this.button_backToMain.TabIndex = 5;
            this.button_backToMain.Text = "Back";
            this.button_backToMain.UseVisualStyleBackColor = true;
            this.button_backToMain.Click += new System.EventHandler(this.button_backToMain_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 821);
            this.Controls.Add(this.button_backToMain);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sername);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_Username);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label textBox_sername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_backToMain;
    }
}