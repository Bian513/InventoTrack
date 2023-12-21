namespace InventoTrack
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.sendotpButton = new System.Windows.Forms.Button();
            this.textBox_otp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.resetpasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendotpButton
            // 
            this.sendotpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sendotpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendotpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendotpButton.ForeColor = System.Drawing.Color.White;
            this.sendotpButton.Location = new System.Drawing.Point(671, 367);
            this.sendotpButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.sendotpButton.Name = "sendotpButton";
            this.sendotpButton.Size = new System.Drawing.Size(139, 34);
            this.sendotpButton.TabIndex = 19;
            this.sendotpButton.Text = "SEND OTP";
            this.sendotpButton.UseVisualStyleBackColor = false;
            this.sendotpButton.Click += new System.EventHandler(this.sendotpButton_Click);
            // 
            // textBox_otp
            // 
            this.textBox_otp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_otp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_otp.Location = new System.Drawing.Point(460, 371);
            this.textBox_otp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox_otp.Name = "textBox_otp";
            this.textBox_otp.Size = new System.Drawing.Size(205, 30);
            this.textBox_otp.TabIndex = 18;
            this.textBox_otp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "OTP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(460, 294);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(350, 30);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(455, 265);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(130, 22);
            this.passwordLabel.TabIndex = 15;
            this.passwordLabel.Text = "New Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(455, 188);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(54, 22);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Email";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(460, 216);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(350, 30);
            this.usernameTextBox.TabIndex = 13;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // resetpasswordButton
            // 
            this.resetpasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(21)))), ((int)(((byte)(200)))));
            this.resetpasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetpasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpasswordButton.ForeColor = System.Drawing.Color.White;
            this.resetpasswordButton.Location = new System.Drawing.Point(460, 428);
            this.resetpasswordButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.resetpasswordButton.Name = "resetpasswordButton";
            this.resetpasswordButton.Size = new System.Drawing.Size(350, 65);
            this.resetpasswordButton.TabIndex = 12;
            this.resetpasswordButton.Text = "RESET PASSWORD";
            this.resetpasswordButton.UseVisualStyleBackColor = false;
            this.resetpasswordButton.Click += new System.EventHandler(this.resetpasswordButton_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoTrack.Properties.Resources.Background_LandingPage;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sendotpButton);
            this.Controls.Add(this.textBox_otp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.resetpasswordButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendotpButton;
        private System.Windows.Forms.TextBox textBox_otp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button resetpasswordButton;
    }
}