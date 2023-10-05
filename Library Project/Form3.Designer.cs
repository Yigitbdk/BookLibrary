namespace Library_Project
{
    partial class Form3
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
            button1 = new System.Windows.Forms.Button();
            BOOKS = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            buttonRefresh = new System.Windows.Forms.Button();
            buttonSearch = new System.Windows.Forms.Button();
            textBoxCustomerName = new System.Windows.Forms.TextBox();
            textBoxSurname = new System.Windows.Forms.TextBox();
            textBoxPhoneNo = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            comboBoxGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button1.Location = new System.Drawing.Point(15, 705);
            button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 48);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BOOKS
            // 
            BOOKS.AutoSize = true;
            BOOKS.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BOOKS.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            BOOKS.Location = new System.Drawing.Point(154, 29);
            BOOKS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            BOOKS.Name = "BOOKS";
            BOOKS.Size = new System.Drawing.Size(762, 156);
            BOOKS.TabIndex = 10;
            BOOKS.Text = "CUSTOMERS";
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button4.Location = new System.Drawing.Point(889, 704);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(112, 48);
            button4.TabIndex = 45;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button2.Location = new System.Drawing.Point(770, 704);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 48);
            button2.TabIndex = 44;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label6.Location = new System.Drawing.Point(19, 409);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(196, 35);
            label6.TabIndex = 43;
            label6.Text = "Phone Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label1.Location = new System.Drawing.Point(19, 249);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 35);
            label1.TabIndex = 38;
            label1.Text = "Name";
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button3.Location = new System.Drawing.Point(651, 704);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 48);
            button3.TabIndex = 37;
            button3.Text = "Add";
            button3.UseMnemonic = false;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.Location = new System.Drawing.Point(15, 201);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(986, 496);
            dataGridView1.TabIndex = 36;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRefresh.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonRefresh.Location = new System.Drawing.Point(382, 704);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(118, 48);
            buttonRefresh.TabIndex = 54;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseMnemonic = false;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(262, 704);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(112, 48);
            buttonSearch.TabIndex = 53;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxCustomerName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxCustomerName.Location = new System.Drawing.Point(19, 288);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new System.Drawing.Size(263, 34);
            textBoxCustomerName.TabIndex = 56;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxSurname.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxSurname.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxSurname.Location = new System.Drawing.Point(19, 368);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new System.Drawing.Size(263, 34);
            textBoxSurname.TabIndex = 57;
            // 
            // textBoxPhoneNo
            // 
            textBoxPhoneNo.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxPhoneNo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxPhoneNo.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxPhoneNo.Location = new System.Drawing.Point(19, 448);
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new System.Drawing.Size(263, 34);
            textBoxPhoneNo.TabIndex = 61;
            textBoxPhoneNo.TextChanged += textBoxPhoneNo_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label9.Location = new System.Drawing.Point(146, 489);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(102, 35);
            label9.TabIndex = 64;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label10.Location = new System.Drawing.Point(19, 489);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(62, 35);
            label10.TabIndex = 65;
            label10.Text = "Age";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label11.Location = new System.Drawing.Point(19, 329);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(119, 35);
            label11.TabIndex = 66;
            label11.Text = "Surname";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            panel1.Controls.Add(numericUpDownAge);
            panel1.Controls.Add(comboBoxGender);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBoxCustomerName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBoxPhoneNo);
            panel1.Location = new System.Drawing.Point(1019, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(306, 783);
            panel1.TabIndex = 67;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            numericUpDownAge.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDownAge.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            numericUpDownAge.Location = new System.Drawing.Point(19, 528);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new System.Drawing.Size(113, 34);
            numericUpDownAge.TabIndex = 69;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            comboBoxGender.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxGender.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new System.Drawing.Point(146, 527);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new System.Drawing.Size(135, 34);
            comboBoxGender.TabIndex = 68;
            comboBoxGender.SelectedIndexChanged += comboBoxMale_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1326, 769);
            Controls.Add(panel1);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSearch);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(BOOKS);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "Form3";
            Text = "Customers";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BOOKS;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}