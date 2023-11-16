namespace InventoTrack
{
    partial class RegisterForm
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
            this.textBox1_username = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_toMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_username
            // 
            this.textBox1_username.Location = new System.Drawing.Point(15, 25);
            this.textBox1_username.Name = "textBox1_username";
            this.textBox1_username.Size = new System.Drawing.Size(588, 20);
            this.textBox1_username.TabIndex = 0;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(15, 64);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(588, 20);
            this.textBox_email.TabIndex = 1;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // textBox_username
            // 
            this.textBox_username.AutoSize = true;
            this.textBox_username.Location = new System.Drawing.Point(12, 9);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(55, 13);
            this.textBox_username.TabIndex = 2;
            this.textBox_username.Text = "Username";
            this.textBox_username.Click += new System.EventHandler(this.textBox_username_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(15, 103);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(588, 20);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(15, 129);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(75, 23);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_toMain
            // 
            this.button_toMain.Location = new System.Drawing.Point(527, 129);
            this.button_toMain.Name = "button_toMain";
            this.button_toMain.Size = new System.Drawing.Size(75, 23);
            this.button_toMain.TabIndex = 7;
            this.button_toMain.Text = "Back";
            this.button_toMain.UseVisualStyleBackColor = true;
            this.button_toMain.Click += new System.EventHandler(this.button_toMain_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 534);
            this.Controls.Add(this.button_toMain);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox1_username);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_username;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label textBox_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_toMain;
    }
}