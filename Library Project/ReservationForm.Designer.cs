namespace Library_Project
{
    partial class ReservationForm
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
            lblReservation = new System.Windows.Forms.Label();
            buttonBack = new System.Windows.Forms.Button();
            comboBoxCustomers = new System.Windows.Forms.ComboBox();
            comboBoxBooks = new System.Windows.Forms.ComboBox();
            dateTimePickerBorrow = new System.Windows.Forms.DateTimePicker();
            dateTimePickerBorrowEnd = new System.Windows.Forms.DateTimePicker();
            lblCustomers = new System.Windows.Forms.Label();
            lblBooks = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            BorrowDate = new System.Windows.Forms.Label();
            BorrowEndDate = new System.Windows.Forms.Label();
            dgvReservation = new System.Windows.Forms.DataGridView();
            buttonSearch = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            panelReservation = new System.Windows.Forms.Panel();
            buttonUpdate = new System.Windows.Forms.Button();
            lblPageNumber = new System.Windows.Forms.Label();
            btnPrevious = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            panelReservation.SuspendLayout();
            SuspendLayout();
            // 
            // lblReservation
            // 
            lblReservation.AutoSize = true;
            lblReservation.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblReservation.Location = new System.Drawing.Point(76, 9);
            lblReservation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblReservation.Name = "lblReservation";
            lblReservation.Size = new System.Drawing.Size(881, 156);
            lblReservation.TabIndex = 0;
            lblReservation.Text = "RESERVATION";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBack.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonBack.Location = new System.Drawing.Point(15, 705);
            buttonBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(94, 48);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += BtnBack_Click;
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            comboBoxCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBoxCustomers.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxCustomers.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new System.Drawing.Point(130, 720);
            comboBoxCustomers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new System.Drawing.Size(227, 33);
            comboBoxCustomers.Sorted = true;
            comboBoxCustomers.TabIndex = 7;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            comboBoxBooks.DisplayMember = " ";
            comboBoxBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            comboBoxBooks.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxBooks.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new System.Drawing.Point(390, 720);
            comboBoxBooks.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new System.Drawing.Size(227, 33);
            comboBoxBooks.Sorted = true;
            comboBoxBooks.TabIndex = 8;
            // 
            // dateTimePickerBorrow
            // 
            dateTimePickerBorrow.CalendarMonthBackground = System.Drawing.Color.FromArgb(42, 46, 52);
            dateTimePickerBorrow.CalendarTrailingForeColor = System.Drawing.Color.Green;
            dateTimePickerBorrow.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerBorrow.Location = new System.Drawing.Point(42, 256);
            dateTimePickerBorrow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            dateTimePickerBorrow.Size = new System.Drawing.Size(227, 32);
            dateTimePickerBorrow.TabIndex = 9;
            dateTimePickerBorrow.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            dateTimePickerBorrow.ValueChanged += dateTimePickerBorrow_ValueChanged;
            // 
            // dateTimePickerBorrowEnd
            // 
            dateTimePickerBorrowEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(42, 46, 52);
            dateTimePickerBorrowEnd.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerBorrowEnd.Location = new System.Drawing.Point(42, 393);
            dateTimePickerBorrowEnd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dateTimePickerBorrowEnd.Name = "dateTimePickerBorrowEnd";
            dateTimePickerBorrowEnd.Size = new System.Drawing.Size(227, 32);
            dateTimePickerBorrowEnd.TabIndex = 10;
            dateTimePickerBorrowEnd.ValueChanged += dateTimePickerBorrowEnd_ValueChanged;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCustomers.Location = new System.Drawing.Point(130, 687);
            lblCustomers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new System.Drawing.Size(112, 26);
            lblCustomers.TabIndex = 11;
            lblCustomers.Text = "Customers";
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblBooks.Location = new System.Drawing.Point(390, 687);
            lblBooks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new System.Drawing.Size(67, 26);
            lblBooks.TabIndex = 12;
            lblBooks.Text = "Books";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(683, 708);
            button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 48);
            button2.TabIndex = 13;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnBook_Click;
            // 
            // BorrowDate
            // 
            BorrowDate.AutoSize = true;
            BorrowDate.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            BorrowDate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BorrowDate.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            BorrowDate.Location = new System.Drawing.Point(42, 200);
            BorrowDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            BorrowDate.Name = "BorrowDate";
            BorrowDate.Size = new System.Drawing.Size(171, 35);
            BorrowDate.TabIndex = 14;
            BorrowDate.Text = "Borrow Date";
            // 
            // BorrowEndDate
            // 
            BorrowEndDate.AutoSize = true;
            BorrowEndDate.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            BorrowEndDate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BorrowEndDate.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            BorrowEndDate.Location = new System.Drawing.Point(42, 334);
            BorrowEndDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            BorrowEndDate.Name = "BorrowEndDate";
            BorrowEndDate.Size = new System.Drawing.Size(226, 35);
            BorrowEndDate.TabIndex = 15;
            BorrowEndDate.Text = "Borrow End Date";
            // 
            // dgvReservation
            // 
            dgvReservation.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvReservation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvReservation.DefaultCellStyle = dataGridViewCellStyle1;
            dgvReservation.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvReservation.Location = new System.Drawing.Point(27, 175);
            dgvReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvReservation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReservation.RowTemplate.Height = 25;
            dgvReservation.Size = new System.Drawing.Size(986, 508);
            dgvReservation.TabIndex = 18;
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
            buttonSearch.Click += BtnSearch_Click;
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
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDelete.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDelete.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonDelete.Location = new System.Drawing.Point(833, 708);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(112, 48);
            buttonDelete.TabIndex = 54;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += BtnDelete_Click;
            // 
            // panelReservation
            // 
            panelReservation.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            panelReservation.Controls.Add(buttonUpdate);
            panelReservation.Controls.Add(BorrowDate);
            panelReservation.Controls.Add(dateTimePickerBorrow);
            panelReservation.Controls.Add(BorrowEndDate);
            panelReservation.Controls.Add(buttonSearch);
            panelReservation.Controls.Add(buttonRefresh);
            panelReservation.Controls.Add(dateTimePickerBorrowEnd);
            panelReservation.Location = new System.Drawing.Point(1022, 1);
            panelReservation.Name = "panelReservation";
            panelReservation.Size = new System.Drawing.Size(306, 783);
            panelReservation.TabIndex = 68;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonUpdate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUpdate.Location = new System.Drawing.Point(33, 614);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(249, 48);
            buttonUpdate.TabIndex = 72;
            buttonUpdate.Text = "Return Book";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += BtnReturnBook_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            lblPageNumber.Location = new System.Drawing.Point(453, 638);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new System.Drawing.Size(58, 20);
            lblPageNumber.TabIndex = 69;
            lblPageNumber.Text = "lblPage";
            // 
            // btnPrevious
            // 
            btnPrevious.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            btnPrevious.Location = new System.Drawing.Point(400, 634);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(49, 29);
            btnPrevious.TabIndex = 70;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            btnNext.Location = new System.Drawing.Point(509, 634);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(49, 29);
            btnNext.TabIndex = 71;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1326, 769);
            Controls.Add(btnNext);
            Controls.Add(panelReservation);
            Controls.Add(lblPageNumber);
            Controls.Add(btnPrevious);
            Controls.Add(dgvReservation);
            Controls.Add(button2);
            Controls.Add(buttonDelete);
            Controls.Add(lblBooks);
            Controls.Add(lblCustomers);
            Controls.Add(comboBoxBooks);
            Controls.Add(comboBoxCustomers);
            Controls.Add(buttonBack);
            Controls.Add(lblReservation);
            ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "ReservationForm";
            Text = "Reservation";
            FormClosing += ReservationForm_FormClosing;
            Load += ReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            panelReservation.ResumeLayout(false);
            panelReservation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrow;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrowEnd;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label BorrowDate;
        private System.Windows.Forms.Label BorrowEndDate;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelReservation;
        public System.Windows.Forms.ComboBox comboBoxBooks;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Button buttonUpdate;
    }
}