namespace Library_Project
{
    partial class BookForm
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
            lblBooks = new System.Windows.Forms.Label();
            buttonBack = new System.Windows.Forms.Button();
            dgvBooks = new System.Windows.Forms.DataGridView();
            buttonAdd = new System.Windows.Forms.Button();
            lblName = new System.Windows.Forms.Label();
            lblWriter = new System.Windows.Forms.Label();
            lblGenre = new System.Windows.Forms.Label();
            lblPages = new System.Windows.Forms.Label();
            labelRecordDate = new System.Windows.Forms.Label();
            buttonDelete = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxWriter = new System.Windows.Forms.TextBox();
            numericUpDownPage = new System.Windows.Forms.NumericUpDown();
            comboBoxGenre = new System.Windows.Forms.ComboBox();
            dateTimePickerRecord = new System.Windows.Forms.DateTimePicker();
            buttonSearch = new System.Windows.Forms.Button();
            panelBook = new System.Windows.Forms.Panel();
            buttonRefresh = new System.Windows.Forms.Button();
            BtnNext = new System.Windows.Forms.Button();
            lblPageNumber = new System.Windows.Forms.Label();
            BtnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPage).BeginInit();
            panelBook.SuspendLayout();
            SuspendLayout();
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBooks.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            lblBooks.Location = new System.Drawing.Point(296, 12);
            lblBooks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new System.Drawing.Size(455, 156);
            lblBooks.TabIndex = 3;
            lblBooks.Text = "BOOKS";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBack.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonBack.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonBack.Location = new System.Drawing.Point(15, 705);
            buttonBack.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(94, 48);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += BtnBack_Click;
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle8;
            dgvBooks.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvBooks.Location = new System.Drawing.Point(15, 199);
            dgvBooks.Name = "dgvBooks";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvBooks.RowTemplate.Height = 25;
            dgvBooks.Size = new System.Drawing.Size(987, 500);
            dgvBooks.TabIndex = 12;
            dgvBooks.DataError += dataGridView1_DataError;
            dgvBooks.RowHeaderMouseClick += dgvBook_RowHeaderMouseClick;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAdd.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAdd.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonAdd.Location = new System.Drawing.Point(653, 705);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(112, 48);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseMnemonic = false;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += BtnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblName.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblName.Location = new System.Drawing.Point(15, 239);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(85, 35);
            lblName.TabIndex = 21;
            lblName.Text = "Name";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWriter.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblWriter.Location = new System.Drawing.Point(17, 320);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new System.Drawing.Size(98, 35);
            lblWriter.TabIndex = 22;
            lblWriter.Text = "Writer";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGenre.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblGenre.Location = new System.Drawing.Point(15, 400);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new System.Drawing.Size(87, 35);
            lblGenre.TabIndex = 23;
            lblGenre.Text = "Genre";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPages.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblPages.Location = new System.Drawing.Point(17, 559);
            lblPages.Name = "lblPages";
            lblPages.Size = new System.Drawing.Size(83, 35);
            lblPages.TabIndex = 24;
            lblPages.Text = "Pages";
            // 
            // labelRecordDate
            // 
            labelRecordDate.AutoSize = true;
            labelRecordDate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelRecordDate.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            labelRecordDate.Location = new System.Drawing.Point(17, 481);
            labelRecordDate.Name = "labelRecordDate";
            labelRecordDate.Size = new System.Drawing.Size(166, 35);
            labelRecordDate.TabIndex = 25;
            labelRecordDate.Text = "Record Date";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDelete.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDelete.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonDelete.Location = new System.Drawing.Point(771, 705);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(112, 48);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += BtnDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonUpdate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonUpdate.Location = new System.Drawing.Point(890, 705);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(112, 48);
            buttonUpdate.TabIndex = 27;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += BtnUpdate_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxName.Location = new System.Drawing.Point(19, 277);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(263, 34);
            textBoxName.TabIndex = 30;
            // 
            // textBoxWriter
            // 
            textBoxWriter.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxWriter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxWriter.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxWriter.Location = new System.Drawing.Point(19, 359);
            textBoxWriter.Name = "textBoxWriter";
            textBoxWriter.Size = new System.Drawing.Size(263, 34);
            textBoxWriter.TabIndex = 32;
            // 
            // numericUpDownPage
            // 
            numericUpDownPage.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            numericUpDownPage.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDownPage.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            numericUpDownPage.Location = new System.Drawing.Point(19, 597);
            numericUpDownPage.Name = "numericUpDownPage";
            numericUpDownPage.Size = new System.Drawing.Size(96, 34);
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
            comboBoxGenre.Location = new System.Drawing.Point(19, 439);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new System.Drawing.Size(262, 34);
            comboBoxGenre.TabIndex = 37;
            // 
            // dateTimePickerRecord
            // 
            dateTimePickerRecord.CalendarForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerRecord.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerRecord.CalendarTitleBackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerRecord.CalendarTitleForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerRecord.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerRecord.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePickerRecord.Location = new System.Drawing.Point(19, 517);
            dateTimePickerRecord.Name = "dateTimePickerRecord";
            dateTimePickerRecord.Size = new System.Drawing.Size(262, 34);
            dateTimePickerRecord.TabIndex = 38;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(242, 704);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(112, 48);
            buttonSearch.TabIndex = 50;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panelBook
            // 
            panelBook.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            panelBook.Controls.Add(lblName);
            panelBook.Controls.Add(lblWriter);
            panelBook.Controls.Add(lblGenre);
            panelBook.Controls.Add(lblPages);
            panelBook.Controls.Add(labelRecordDate);
            panelBook.Controls.Add(textBoxName);
            panelBook.Controls.Add(textBoxWriter);
            panelBook.Controls.Add(numericUpDownPage);
            panelBook.Controls.Add(comboBoxGenre);
            panelBook.Controls.Add(dateTimePickerRecord);
            panelBook.Location = new System.Drawing.Point(1017, 0);
            panelBook.Name = "panelBook";
            panelBook.Size = new System.Drawing.Size(306, 783);
            panelBook.TabIndex = 51;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRefresh.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonRefresh.Location = new System.Drawing.Point(367, 704);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(119, 48);
            buttonRefresh.TabIndex = 52;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseMnemonic = false;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += BtnRefresh_Click;
            // 
            // BtnNext
            // 
            BtnNext.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            BtnNext.Location = new System.Drawing.Point(521, 637);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new System.Drawing.Size(49, 29);
            BtnNext.TabIndex = 74;
            BtnNext.Text = ">";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            lblPageNumber.Location = new System.Drawing.Point(463, 641);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new System.Drawing.Size(58, 20);
            lblPageNumber.TabIndex = 72;
            lblPageNumber.Text = "lblPage";
            // 
            // BtnPrevious
            // 
            BtnPrevious.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            BtnPrevious.Location = new System.Drawing.Point(410, 637);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new System.Drawing.Size(49, 29);
            BtnPrevious.TabIndex = 73;
            BtnPrevious.Text = "<";
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1323, 767);
            Controls.Add(BtnNext);
            Controls.Add(lblPageNumber);
            Controls.Add(BtnPrevious);
            Controls.Add(buttonRefresh);
            Controls.Add(panelBook);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonBack);
            Controls.Add(dgvBooks);
            Controls.Add(lblBooks);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdd);
            ForeColor = System.Drawing.Color.SandyBrown;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "BookForm";
            Text = "Books";
            FormClosing += BookForm_FormClosing;
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPage).EndInit();
            panelBook.ResumeLayout(false);
            panelBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label labelRecordDate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.NumericUpDown numericUpDownPage;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecord;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.Button buttonRefresh;
        public System.Windows.Forms.DataGridView dgvBooks;
        public System.Windows.Forms.Button BtnNext;
        public System.Windows.Forms.Label lblPageNumber;
        public System.Windows.Forms.Button BtnPrevious;
    }
}