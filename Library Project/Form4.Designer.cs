namespace Library_Project
{
    partial class Form4
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            buttonSearch = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(76, 9);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(881, 156);
            label1.TabIndex = 0;
            label1.Text = "RESERVATION";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(14, 687);
            button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(72, 69);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox1.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(130, 720);
            comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(227, 33);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Format += comboBox1_Format;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            comboBox2.DisplayMember = " ";
            comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBox2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox2.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(390, 720);
            comboBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(227, 33);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(42, 46, 52);
            dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Green;
            dateTimePicker1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker1.Location = new System.Drawing.Point(42, 256);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(227, 32);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(42, 46, 52);
            dateTimePicker2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker2.Location = new System.Drawing.Point(42, 393);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(227, 32);
            dateTimePicker2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(130, 687);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(112, 26);
            label2.TabIndex = 11;
            label2.Text = "Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(390, 687);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 26);
            label3.TabIndex = 12;
            label3.Text = "Books";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(648, 705);
            button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 48);
            button2.TabIndex = 13;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label4.Location = new System.Drawing.Point(42, 200);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(171, 35);
            label4.TabIndex = 14;
            label4.Text = "Date of Take";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label5.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label5.Location = new System.Drawing.Point(42, 334);
            label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(196, 35);
            label5.TabIndex = 15;
            label5.Text = "Date of Return";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.Location = new System.Drawing.Point(27, 175);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(986, 496);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(33, 704);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(112, 48);
            buttonSearch.TabIndex = 52;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRefresh.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonRefresh.Location = new System.Drawing.Point(163, 704);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(119, 48);
            buttonRefresh.TabIndex = 53;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseMnemonic = false;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button3.Location = new System.Drawing.Point(777, 705);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 48);
            button3.TabIndex = 54;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonUpdate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonUpdate.Location = new System.Drawing.Point(901, 705);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(112, 48);
            buttonUpdate.TabIndex = 55;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Location = new System.Drawing.Point(1022, 1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(306, 783);
            panel1.TabIndex = 68;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1326, 769);
            Controls.Add(panel1);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "Form4";
            Text = "Reservation";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}