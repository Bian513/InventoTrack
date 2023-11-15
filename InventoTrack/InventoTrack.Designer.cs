namespace InventoTrack
{
    partial class InventoTrack
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newButton_Click = new System.Windows.Forms.Button();
            this.saveButton_Click = new System.Windows.Forms.Button();
            this.deleteButton_Click = new System.Windows.Forms.Button();
            this.updateButton_Click = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.quantityNUD = new System.Windows.Forms.NumericUpDown();
            this.categoryBox = new System.Windows.Forms.Label();
            this.priceNumericUpdown = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.Label();
            this.button_toLogin = new System.Windows.Forms.Button();
            this.button_toRegister = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1398, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newButton_Click
            // 
            this.newButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton_Click.Location = new System.Drawing.Point(19, 158);
            this.newButton_Click.Name = "newButton_Click";
            this.newButton_Click.Size = new System.Drawing.Size(300, 40);
            this.newButton_Click.TabIndex = 1;
            this.newButton_Click.Text = "NEW";
            this.newButton_Click.UseVisualStyleBackColor = true;
            this.newButton_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton_Click
            // 
            this.saveButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton_Click.Location = new System.Drawing.Point(366, 158);
            this.saveButton_Click.Name = "saveButton_Click";
            this.saveButton_Click.Size = new System.Drawing.Size(300, 40);
            this.saveButton_Click.TabIndex = 2;
            this.saveButton_Click.Text = "SAVE";
            this.saveButton_Click.UseVisualStyleBackColor = true;
            this.saveButton_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton_Click
            // 
            this.deleteButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton_Click.Location = new System.Drawing.Point(709, 158);
            this.deleteButton_Click.Name = "deleteButton_Click";
            this.deleteButton_Click.Size = new System.Drawing.Size(300, 40);
            this.deleteButton_Click.TabIndex = 3;
            this.deleteButton_Click.Text = "DELETE";
            this.deleteButton_Click.UseVisualStyleBackColor = true;
            this.deleteButton_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton_Click
            // 
            this.updateButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton_Click.Location = new System.Drawing.Point(1052, 158);
            this.updateButton_Click.Name = "updateButton_Click";
            this.updateButton_Click.Size = new System.Drawing.Size(300, 40);
            this.updateButton_Click.TabIndex = 4;
            this.updateButton_Click.Text = "UPDATE";
            this.updateButton_Click.UseVisualStyleBackColor = true;
            this.updateButton_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(19, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(518, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.AutoSize = true;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(13, 25);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(49, 17);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "Name";
            this.TextBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Makanan",
            "Deterjen",
            "Susu",
            "Rokok"});
            this.categoryComboBox.Location = new System.Drawing.Point(19, 113);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(517, 22);
            this.categoryComboBox.TabIndex = 17;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // priceNUD
            // 
            this.priceNUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceNUD.Location = new System.Drawing.Point(709, 52);
            this.priceNUD.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(519, 20);
            this.priceNUD.TabIndex = 18;
            this.priceNUD.Tag = "Rp";
            this.priceNUD.ThousandsSeparator = true;
            this.priceNUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // quantityNUD
            // 
            this.quantityNUD.Location = new System.Drawing.Point(709, 115);
            this.quantityNUD.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.quantityNUD.Name = "quantityNUD";
            this.quantityNUD.Size = new System.Drawing.Size(519, 20);
            this.quantityNUD.TabIndex = 19;
            this.quantityNUD.Tag = "";
            this.quantityNUD.ThousandsSeparator = true;
            this.quantityNUD.ValueChanged += new System.EventHandler(this.quantityNUD_ValueChanged);
            // 
            // categoryBox
            // 
            this.categoryBox.AutoSize = true;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.Location = new System.Drawing.Point(13, 85);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(73, 17);
            this.categoryBox.TabIndex = 20;
            this.categoryBox.Text = "Category";
            this.categoryBox.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // priceNumericUpdown
            // 
            this.priceNumericUpdown.AutoSize = true;
            this.priceNumericUpdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpdown.Location = new System.Drawing.Point(704, 25);
            this.priceNumericUpdown.Name = "priceNumericUpdown";
            this.priceNumericUpdown.Size = new System.Drawing.Size(45, 17);
            this.priceNumericUpdown.TabIndex = 21;
            this.priceNumericUpdown.Text = "Price";
            this.priceNumericUpdown.Click += new System.EventHandler(this.priceNumericUpdown_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.AutoSize = true;
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(704, 85);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(69, 17);
            this.quantityNumericUpDown.TabIndex = 22;
            this.quantityNumericUpDown.Text = "Quantity";
            this.quantityNumericUpDown.Click += new System.EventHandler(this.quantityNumericUpDown_Click);
            // 
            // button_toLogin
            // 
            this.button_toLogin.Location = new System.Drawing.Point(1311, 12);
            this.button_toLogin.Name = "button_toLogin";
            this.button_toLogin.Size = new System.Drawing.Size(75, 23);
            this.button_toLogin.TabIndex = 23;
            this.button_toLogin.Text = "Login";
            this.button_toLogin.UseVisualStyleBackColor = true;
            this.button_toLogin.Click += new System.EventHandler(this.button_toLogin_Click);
            // 
            // button_toRegister
            // 
            this.button_toRegister.Location = new System.Drawing.Point(1311, 41);
            this.button_toRegister.Name = "button_toRegister";
            this.button_toRegister.Size = new System.Drawing.Size(75, 23);
            this.button_toRegister.TabIndex = 24;
            this.button_toRegister.Text = "Register";
            this.button_toRegister.UseVisualStyleBackColor = true;
            this.button_toRegister.Click += new System.EventHandler(this.button_toRegister_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(1311, 70);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 25;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // InventoTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 598);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_toRegister);
            this.Controls.Add(this.button_toLogin);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.priceNumericUpdown);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.quantityNUD);
            this.Controls.Add(this.priceNUD);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.updateButton_Click);
            this.Controls.Add(this.deleteButton_Click);
            this.Controls.Add(this.saveButton_Click);
            this.Controls.Add(this.newButton_Click);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoTrack";
            this.Text = "InventoTrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newButton_Click;
        private System.Windows.Forms.Button saveButton_Click;
        private System.Windows.Forms.Button deleteButton_Click;
        private System.Windows.Forms.Button updateButton_Click;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label TextBox1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.NumericUpDown quantityNUD;
        private System.Windows.Forms.Label categoryBox;
        private System.Windows.Forms.Label priceNumericUpdown;
        private System.Windows.Forms.Label quantityNumericUpDown;
        private System.Windows.Forms.Button button_toLogin;
        private System.Windows.Forms.Button button_toRegister;
        private System.Windows.Forms.Button button_close;
    }
}

