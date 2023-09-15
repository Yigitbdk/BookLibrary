namespace Library_Project
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            BOOKS = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelRecord = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxWriter = new System.Windows.Forms.TextBox();
            numericUpDownPage = new System.Windows.Forms.NumericUpDown();
            comboBoxGenre = new System.Windows.Forms.ComboBox();
            dateTimePickerRecord = new System.Windows.Forms.DateTimePicker();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPage).BeginInit();
            SuspendLayout();
            // 
            // BOOKS
            // 
            BOOKS.AutoSize = true;
            BOOKS.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BOOKS.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            BOOKS.Location = new System.Drawing.Point(380, 17);
            BOOKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BOOKS.Name = "BOOKS";
            BOOKS.Size = new System.Drawing.Size(372, 126);
            BOOKS.TabIndex = 3;
            BOOKS.Text = "BOOKS";
            BOOKS.Click += BOOKS_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button3.Location = new System.Drawing.Point(21, 528);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(62, 48);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.Location = new System.Drawing.Point(21, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(731, 327);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button1.Location = new System.Drawing.Point(185, 528);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(185, 48);
            button1.TabIndex = 13;
            button1.Text = "Add New Book";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label2.Location = new System.Drawing.Point(782, 180);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 27);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label3.Location = new System.Drawing.Point(782, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 27);
            label3.TabIndex = 22;
            label3.Text = "Writer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label4.Location = new System.Drawing.Point(782, 304);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 27);
            label4.TabIndex = 23;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label5.Location = new System.Drawing.Point(782, 367);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(138, 27);
            label5.TabIndex = 24;
            label5.Text = "PageNumber";
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelRecord.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            labelRecord.Location = new System.Drawing.Point(782, 429);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new System.Drawing.Size(133, 27);
            labelRecord.TabIndex = 25;
            labelRecord.Text = "Record Date";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button2.Location = new System.Drawing.Point(376, 528);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(185, 48);
            button2.TabIndex = 26;
            button2.Text = "Delete The Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button4.Location = new System.Drawing.Point(567, 528);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(185, 48);
            button4.TabIndex = 27;
            button4.Text = "Update the Book";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxName.Location = new System.Drawing.Point(782, 210);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(144, 29);
            textBoxName.TabIndex = 30;
            textBoxName.TextChanged += textBoxId_TextChanged;
            // 
            // textBoxWriter
            // 
            textBoxWriter.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxWriter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxWriter.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxWriter.Location = new System.Drawing.Point(782, 272);
            textBoxWriter.Name = "textBoxWriter";
            textBoxWriter.Size = new System.Drawing.Size(144, 29);
            textBoxWriter.TabIndex = 32;
            // 
            // numericUpDownPage
            // 
            numericUpDownPage.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            numericUpDownPage.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDownPage.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            numericUpDownPage.Location = new System.Drawing.Point(782, 397);
            numericUpDownPage.Name = "numericUpDownPage";
            numericUpDownPage.Size = new System.Drawing.Size(144, 29);
            numericUpDownPage.TabIndex = 36;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            comboBoxGenre.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxGenre.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "True Crime", "Biographies and Autobiographies", "Novel", "Poetry", "Action and Adventure", "Comic Book", "Manga", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction", "Cookbooks", "Essays", "History" });
            comboBoxGenre.Location = new System.Drawing.Point(782, 334);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new System.Drawing.Size(144, 30);
            comboBoxGenre.TabIndex = 37;
            comboBoxGenre.SelectedIndexChanged += comboBoxGenre_SelectedIndexChanged;
            // 
            // dateTimePickerRecord
            // 
            dateTimePickerRecord.CalendarForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerRecord.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerRecord.CalendarTitleBackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerRecord.CalendarTitleForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerRecord.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerRecord.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePickerRecord.Location = new System.Drawing.Point(782, 459);
            dateTimePickerRecord.Name = "dateTimePickerRecord";
            dateTimePickerRecord.Size = new System.Drawing.Size(144, 29);
            dateTimePickerRecord.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBox1.Location = new System.Drawing.Point(21, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(144, 25);
            textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBox2.Location = new System.Drawing.Point(21, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(144, 25);
            textBox2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label1.Location = new System.Drawing.Point(21, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 22);
            label1.TabIndex = 40;
            label1.Text = "Writer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label7.Location = new System.Drawing.Point(21, 30);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 22);
            label7.TabIndex = 39;
            label7.Text = "Name";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(171, 110);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(142, 23);
            dateTimePicker2.TabIndex = 48;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            comboBox2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox2.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(171, 56);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(142, 26);
            comboBox2.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label8.Location = new System.Drawing.Point(171, 85);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(102, 22);
            label8.TabIndex = 44;
            label8.Text = "Record Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label9.Location = new System.Drawing.Point(171, 31);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 22);
            label9.TabIndex = 43;
            label9.Text = "Genre";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(21, 139);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(293, 35);
            buttonSearch.TabIndex = 50;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1078, 599);
            Controls.Add(buttonSearch);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(dateTimePickerRecord);
            Controls.Add(comboBoxGenre);
            Controls.Add(numericUpDownPage);
            Controls.Add(textBoxWriter);
            Controls.Add(textBoxName);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(labelRecord);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(BOOKS);
            ForeColor = System.Drawing.Color.SandyBrown;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Books";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label BOOKS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.NumericUpDown numericUpDownPage;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSearch;
    }
}