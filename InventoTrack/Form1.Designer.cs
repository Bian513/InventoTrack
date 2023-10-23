namespace InventoTrack
{
    partial class Form1
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.categoryTextBox = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.newButton_Click.Location = new System.Drawing.Point(18, 158);
            this.newButton_Click.Name = "newButton_Click";
            this.newButton_Click.Size = new System.Drawing.Size(322, 40);
            this.newButton_Click.TabIndex = 1;
            this.newButton_Click.Text = "NEW";
            this.newButton_Click.UseVisualStyleBackColor = true;
            this.newButton_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton_Click
            // 
            this.saveButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton_Click.Location = new System.Drawing.Point(361, 158);
            this.saveButton_Click.Name = "saveButton_Click";
            this.saveButton_Click.Size = new System.Drawing.Size(322, 40);
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
            this.deleteButton_Click.Size = new System.Drawing.Size(322, 40);
            this.deleteButton_Click.TabIndex = 3;
            this.deleteButton_Click.Text = "DELETE";
            this.deleteButton_Click.UseVisualStyleBackColor = true;
            this.deleteButton_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton_Click
            // 
            this.updateButton_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton_Click.Location = new System.Drawing.Point(1057, 158);
            this.updateButton_Click.Name = "updateButton_Click";
            this.updateButton_Click.Size = new System.Drawing.Size(322, 40);
            this.updateButton_Click.TabIndex = 4;
            this.updateButton_Click.Text = "UPDATE";
            this.updateButton_Click.UseVisualStyleBackColor = true;
            this.updateButton_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(19, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(518, 26);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoSize = true;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(13, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(68, 25);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Text = "Name";
            this.nameTextBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Makanan",
            "Deterjen",
            "Susu",
            "Rokok"});
            this.comboBox1.Location = new System.Drawing.Point(19, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(517, 26);
            this.comboBox1.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(709, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(519, 26);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Tag = "Rp";
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(709, 115);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(519, 26);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.ThousandsSeparator = true;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.AutoSize = true;
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(13, 85);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 25);
            this.categoryTextBox.TabIndex = 20;
            this.categoryTextBox.Text = "Category";
            this.categoryTextBox.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // priceTextBox
            // 
            this.priceTextBox.AutoSize = true;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(704, 25);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(61, 25);
            this.priceTextBox.TabIndex = 21;
            this.priceTextBox.Text = "Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.AutoSize = true;
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(704, 85);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(93, 25);
            this.quantityTextBox.TabIndex = 22;
            this.quantityTextBox.Text = "Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 598);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.updateButton_Click);
            this.Controls.Add(this.deleteButton_Click);
            this.Controls.Add(this.saveButton_Click);
            this.Controls.Add(this.newButton_Click);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "InventoTrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newButton_Click;
        private System.Windows.Forms.Button saveButton_Click;
        private System.Windows.Forms.Button deleteButton_Click;
        private System.Windows.Forms.Button updateButton_Click;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label nameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label categoryTextBox;
        private System.Windows.Forms.Label priceTextBox;
        private System.Windows.Forms.Label quantityTextBox;
    }
}

