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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            BOOKS.Location = new System.Drawing.Point(434, 23);
            BOOKS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            BOOKS.Name = "BOOKS";
            BOOKS.Size = new System.Drawing.Size(455, 156);
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
            button3.Location = new System.Drawing.Point(24, 704);
            button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(71, 64);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.Location = new System.Drawing.Point(24, 240);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(835, 436);
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
            button1.Location = new System.Drawing.Point(211, 704);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(211, 64);
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
            label2.Location = new System.Drawing.Point(894, 240);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 35);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label3.Location = new System.Drawing.Point(894, 323);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 35);
            label3.TabIndex = 22;
            label3.Text = "Writer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label4.Location = new System.Drawing.Point(894, 405);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 35);
            label4.TabIndex = 23;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label5.Location = new System.Drawing.Point(894, 489);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(170, 35);
            label5.TabIndex = 24;
            label5.Text = "PageNumber";
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelRecord.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            labelRecord.Location = new System.Drawing.Point(894, 572);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new System.Drawing.Size(166, 35);
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
            button2.Location = new System.Drawing.Point(430, 704);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(211, 64);
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
            button4.Location = new System.Drawing.Point(648, 704);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(211, 64);
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
            textBoxName.Location = new System.Drawing.Point(894, 280);
            textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(164, 34);
            textBoxName.TabIndex = 30;
            textBoxName.TextChanged += textBoxId_TextChanged;
            // 
            // textBoxWriter
            // 
            textBoxWriter.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxWriter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxWriter.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxWriter.Location = new System.Drawing.Point(894, 363);
            textBoxWriter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxWriter.Name = "textBoxWriter";
            textBoxWriter.Size = new System.Drawing.Size(164, 34);
            textBoxWriter.TabIndex = 32;
            // 
            // numericUpDownPage
            // 
            numericUpDownPage.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            numericUpDownPage.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDownPage.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            numericUpDownPage.Location = new System.Drawing.Point(894, 529);
            numericUpDownPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numericUpDownPage.Name = "numericUpDownPage";
            numericUpDownPage.Size = new System.Drawing.Size(165, 34);
            numericUpDownPage.TabIndex = 36;
            numericUpDownPage.ValueChanged += numericUpDownPage_ValueChanged;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            comboBoxGenre.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxGenre.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "True Crime", "Biographies and Autobiographies", "Novel", "Poetry", "Action and Adventure", "Comic Book", "Manga", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction", "Cookbooks", "Essays", "History" });
            comboBoxGenre.Location = new System.Drawing.Point(894, 445);
            comboBoxGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new System.Drawing.Size(164, 34);
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
            dateTimePickerRecord.Location = new System.Drawing.Point(894, 612);
            dateTimePickerRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePickerRecord.Name = "dateTimePickerRecord";
            dateTimePickerRecord.Size = new System.Drawing.Size(164, 34);
            dateTimePickerRecord.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBox1.Location = new System.Drawing.Point(24, 144);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(164, 29);
            textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBox2.Location = new System.Drawing.Point(24, 73);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(164, 29);
            textBox2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label1.Location = new System.Drawing.Point(24, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 26);
            label1.TabIndex = 40;
            label1.Text = "Writer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label7.Location = new System.Drawing.Point(24, 40);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 26);
            label7.TabIndex = 39;
            label7.Text = "Name";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(195, 147);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(162, 27);
            dateTimePicker2.TabIndex = 48;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            comboBox2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBox2.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "True Crime", "Biographies and Autobiographies", "Novel", "Poetry", "Action and Adventure", "Comic Book", "Manga", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction", "Cookbooks", "Essays", "History" });
            comboBox2.Location = new System.Drawing.Point(195, 75);
            comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(162, 30);
            comboBox2.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label8.Location = new System.Drawing.Point(195, 113);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(128, 26);
            label8.TabIndex = 44;
            label8.Text = "Record Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label9.Location = new System.Drawing.Point(195, 41);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(69, 26);
            label9.TabIndex = 43;
            label9.Text = "Genre";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(24, 185);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(335, 47);
            buttonSearch.TabIndex = 50;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1232, 799);
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
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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