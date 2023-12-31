﻿namespace InventoTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoTrack));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.downloadreportButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.quantityNUD = new System.Windows.Forms.NumericUpDown();
            this.categoryBox = new System.Windows.Forms.Label();
            this.priceNumericUpdown = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.Label();
            this.signoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(59, 246);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1143, 276);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.editButton.Location = new System.Drawing.Point(882, 185);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(320, 50);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.saveButton.Location = new System.Drawing.Point(59, 185);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(320, 50);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.deleteButton.Location = new System.Drawing.Point(469, 185);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(320, 50);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // downloadreportButton
            // 
            this.downloadreportButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.downloadreportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadreportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadreportButton.Location = new System.Drawing.Point(469, 530);
            this.downloadreportButton.Name = "downloadreportButton";
            this.downloadreportButton.Size = new System.Drawing.Size(320, 50);
            this.downloadreportButton.TabIndex = 4;
            this.downloadreportButton.Text = "DOWNLOAD REPORT";
            this.downloadreportButton.UseVisualStyleBackColor = false;
            this.downloadreportButton.Click += new System.EventHandler(this.downloadreportButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(59, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(450, 26);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.AutoSize = true;
            this.TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(54, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(55, 20);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "Name";
            this.TextBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Makanan",
            "Minuman",
            "Deterjen",
            "Susu",
            "Rokok",
            "Alat Tulis",
            "Sabun",
            "Shampoo",
            "Penyedap Rasa",
            "Parfum",
            "Pampers",
            "Pasta gigi",
            "Sikat gigi",
            "Obat-obatan",
            "Kosmetik",
            ""});
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryComboBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Makanan",
            "Minuman",
            "Deterjen",
            "Susu",
            "Rokok",
            "Alat Tulis",
            "Sabun",
            "Shampoo",
            "Penyedap Rasa",
            "Parfum",
            "Pampers",
            "Pasta gigi",
            "Sikat gigi",
            "Obat-obatan",
            "Kosmetik"});
            this.categoryComboBox.Location = new System.Drawing.Point(59, 129);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(450, 26);
            this.categoryComboBox.TabIndex = 17;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // priceNUD
            // 
            this.priceNUD.BackColor = System.Drawing.Color.Gainsboro;
            this.priceNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceNUD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceNUD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceNUD.Location = new System.Drawing.Point(752, 58);
            this.priceNUD.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(450, 26);
            this.priceNUD.TabIndex = 18;
            this.priceNUD.Tag = "Rp";
            this.priceNUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // quantityNUD
            // 
            this.quantityNUD.BackColor = System.Drawing.Color.Gainsboro;
            this.quantityNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityNUD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quantityNUD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNUD.Location = new System.Drawing.Point(752, 130);
            this.quantityNUD.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.quantityNUD.Name = "quantityNUD";
            this.quantityNUD.Size = new System.Drawing.Size(450, 26);
            this.quantityNUD.TabIndex = 19;
            this.quantityNUD.Tag = "";
            this.quantityNUD.ThousandsSeparator = true;
            this.quantityNUD.ValueChanged += new System.EventHandler(this.quantityNUD_ValueChanged);
            // 
            // categoryBox
            // 
            this.categoryBox.AutoSize = true;
            this.categoryBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.ForeColor = System.Drawing.Color.White;
            this.categoryBox.Location = new System.Drawing.Point(54, 98);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(81, 20);
            this.categoryBox.TabIndex = 20;
            this.categoryBox.Text = "Category";
            this.categoryBox.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // priceNumericUpdown
            // 
            this.priceNumericUpdown.AutoSize = true;
            this.priceNumericUpdown.BackColor = System.Drawing.Color.Transparent;
            this.priceNumericUpdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpdown.ForeColor = System.Drawing.Color.White;
            this.priceNumericUpdown.Location = new System.Drawing.Point(747, 24);
            this.priceNumericUpdown.Name = "priceNumericUpdown";
            this.priceNumericUpdown.Size = new System.Drawing.Size(49, 20);
            this.priceNumericUpdown.TabIndex = 21;
            this.priceNumericUpdown.Text = "Price";
            this.priceNumericUpdown.Click += new System.EventHandler(this.priceNumericUpdown_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.AutoSize = true;
            this.quantityNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.quantityNumericUpDown.Location = new System.Drawing.Point(747, 98);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.quantityNumericUpDown.TabIndex = 22;
            this.quantityNumericUpDown.Text = "Quantity";
            this.quantityNumericUpDown.Click += new System.EventHandler(this.quantityNumericUpDown_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.BackColor = System.Drawing.Color.Aqua;
            this.signoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutButton.Location = new System.Drawing.Point(469, 590);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(320, 50);
            this.signoutButton.TabIndex = 26;
            this.signoutButton.Text = "SIGN OUT";
            this.signoutButton.UseVisualStyleBackColor = false;
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // InventoTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoTrack.Properties.Resources.Background_MainPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.priceNumericUpdown);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.quantityNUD);
            this.Controls.Add(this.priceNUD);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.downloadreportButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataGridView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoTrack";
            this.Text = "InventoTrack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button downloadreportButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label TextBox1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.NumericUpDown quantityNUD;
        private System.Windows.Forms.Label categoryBox;
        private System.Windows.Forms.Label priceNumericUpdown;
        private System.Windows.Forms.Label quantityNumericUpDown;
        private System.Windows.Forms.Button signoutButton;
    }
}

