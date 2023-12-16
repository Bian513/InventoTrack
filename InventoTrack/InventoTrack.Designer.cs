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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoTrack));
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // newButton_Click
            // 
            this.newButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newButton_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.newButton_Click.Location = new System.Drawing.Point(59, 197);
            this.newButton_Click.Name = "newButton_Click";
            this.newButton_Click.Size = new System.Drawing.Size(320, 50);
            this.newButton_Click.TabIndex = 1;
            this.newButton_Click.Text = "NEW";
            this.newButton_Click.UseVisualStyleBackColor = false;
            this.newButton_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton_Click
            // 
            this.saveButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveButton_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.saveButton_Click.Location = new System.Drawing.Point(469, 197);
            this.saveButton_Click.Name = "saveButton_Click";
            this.saveButton_Click.Size = new System.Drawing.Size(320, 50);
            this.saveButton_Click.TabIndex = 2;
            this.saveButton_Click.Text = "SAVE";
            this.saveButton_Click.UseVisualStyleBackColor = false;
            this.saveButton_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton_Click
            // 
            this.deleteButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteButton_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.deleteButton_Click.Location = new System.Drawing.Point(882, 197);
            this.deleteButton_Click.Name = "deleteButton_Click";
            this.deleteButton_Click.Size = new System.Drawing.Size(320, 50);
            this.deleteButton_Click.TabIndex = 3;
            this.deleteButton_Click.Text = "DELETE";
            this.deleteButton_Click.UseVisualStyleBackColor = false;
            this.deleteButton_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton_Click
            // 
            this.updateButton_Click.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.updateButton_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton_Click.Location = new System.Drawing.Point(469, 542);
            this.updateButton_Click.Name = "updateButton_Click";
            this.updateButton_Click.Size = new System.Drawing.Size(320, 50);
            this.updateButton_Click.TabIndex = 4;
            this.updateButton_Click.Text = "SHOW REPORT";
            this.updateButton_Click.UseVisualStyleBackColor = false;
            this.updateButton_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(59, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(450, 35);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.AutoSize = true;
            this.TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(56)))));
            this.TextBox1.Location = new System.Drawing.Point(54, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(82, 29);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "Name";
            this.TextBox1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.categoryComboBox.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            "Parfum"});
            this.categoryComboBox.Location = new System.Drawing.Point(59, 141);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(450, 35);
            this.categoryComboBox.TabIndex = 17;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // priceNUD
            // 
            this.priceNUD.BackColor = System.Drawing.Color.Gainsboro;
            this.priceNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceNUD.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.priceNUD.Size = new System.Drawing.Size(450, 35);
            this.priceNUD.TabIndex = 18;
            this.priceNUD.Tag = "Rp";
            this.priceNUD.ThousandsSeparator = true;
            this.priceNUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // quantityNUD
            // 
            this.quantityNUD.BackColor = System.Drawing.Color.Gainsboro;
            this.quantityNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityNUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityNUD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNUD.Location = new System.Drawing.Point(752, 142);
            this.quantityNUD.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.quantityNUD.Name = "quantityNUD";
            this.quantityNUD.Size = new System.Drawing.Size(450, 35);
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
            this.categoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(56)))));
            this.categoryBox.Location = new System.Drawing.Point(54, 110);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(118, 29);
            this.categoryBox.TabIndex = 20;
            this.categoryBox.Text = "Category";
            this.categoryBox.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // priceNumericUpdown
            // 
            this.priceNumericUpdown.AutoSize = true;
            this.priceNumericUpdown.BackColor = System.Drawing.Color.Transparent;
            this.priceNumericUpdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(56)))));
            this.priceNumericUpdown.Location = new System.Drawing.Point(747, 24);
            this.priceNumericUpdown.Name = "priceNumericUpdown";
            this.priceNumericUpdown.Size = new System.Drawing.Size(74, 29);
            this.priceNumericUpdown.TabIndex = 21;
            this.priceNumericUpdown.Text = "Price";
            this.priceNumericUpdown.Click += new System.EventHandler(this.priceNumericUpdown_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.AutoSize = true;
            this.quantityNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(56)))));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(747, 110);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(108, 29);
            this.quantityNumericUpDown.TabIndex = 22;
            this.quantityNumericUpDown.Text = "Quantity";
            this.quantityNumericUpDown.Click += new System.EventHandler(this.quantityNumericUpDown_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "SIGN OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // InventoTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoTrack.Properties.Resources.Background_MainPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.button1);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoTrack";
            this.Text = "InventoTrack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button button1;
    }
}

