namespace Library_Project
{
    partial class CustomerForm
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
            buttonBack = new System.Windows.Forms.Button();
            lblCustomers = new System.Windows.Forms.Label();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            labelPhoneNumber = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            buttonAdd = new System.Windows.Forms.Button();
            dgvCustomers = new System.Windows.Forms.DataGridView();
            buttonRefresh = new System.Windows.Forms.Button();
            buttonSearch = new System.Windows.Forms.Button();
            textBoxCustomerName = new System.Windows.Forms.TextBox();
            textBoxSurname = new System.Windows.Forms.TextBox();
            textBoxPhoneNo = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            lblAge = new System.Windows.Forms.Label();
            labelSurname = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            comboBoxGender = new System.Windows.Forms.ComboBox();
            BtnNext = new System.Windows.Forms.Button();
            lblPageNumber = new System.Windows.Forms.Label();
            BtnPrevious = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBack.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonBack.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonBack.Location = new System.Drawing.Point(15, 705);
            buttonBack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(94, 48);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += BtnBack_Click;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCustomers.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            lblCustomers.Location = new System.Drawing.Point(154, 29);
            lblCustomers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new System.Drawing.Size(762, 156);
            lblCustomers.TabIndex = 10;
            lblCustomers.Text = "CUSTOMERS";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonUpdate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonUpdate.Location = new System.Drawing.Point(889, 704);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(112, 48);
            buttonUpdate.TabIndex = 45;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += BtnUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDelete.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDelete.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonDelete.Location = new System.Drawing.Point(770, 704);
            buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(112, 48);
            buttonDelete.TabIndex = 44;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += BtnDelete_Click;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            labelPhoneNumber.Location = new System.Drawing.Point(19, 409);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new System.Drawing.Size(196, 35);
            labelPhoneNumber.TabIndex = 43;
            labelPhoneNumber.Text = "Phone Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblName.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblName.Location = new System.Drawing.Point(19, 249);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(85, 35);
            lblName.TabIndex = 38;
            lblName.Text = "Name";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAdd.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAdd.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonAdd.Location = new System.Drawing.Point(651, 704);
            buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(112, 48);
            buttonAdd.TabIndex = 37;
            buttonAdd.Text = "Add";
            buttonAdd.UseMnemonic = false;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += BtnAdd_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.GridColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dgvCustomers.Location = new System.Drawing.Point(15, 201);
            dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 25;
            dgvCustomers.Size = new System.Drawing.Size(986, 496);
            dgvCustomers.TabIndex = 36;
            dgvCustomers.RowHeaderMouseClick += dgvCustomers_RowHeaderMouseClick_1;
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
            buttonRefresh.Click += BtnRefresh_Click;
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
            buttonSearch.Click += BtnSearch_Click;
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
            textBoxPhoneNo.MaxLength = 11;
            textBoxPhoneNo.Name = "textBoxPhoneNo";
            textBoxPhoneNo.Size = new System.Drawing.Size(263, 34);
            textBoxPhoneNo.TabIndex = 61;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGender.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblGender.Location = new System.Drawing.Point(146, 489);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(102, 35);
            lblGender.TabIndex = 64;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblAge.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblAge.Location = new System.Drawing.Point(19, 489);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(62, 35);
            lblAge.TabIndex = 65;
            lblAge.Text = "Age";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSurname.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            labelSurname.Location = new System.Drawing.Point(19, 329);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new System.Drawing.Size(119, 35);
            labelSurname.TabIndex = 66;
            labelSurname.Text = "Surname";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            panel1.Controls.Add(numericUpDownAge);
            panel1.Controls.Add(comboBoxGender);
            panel1.Controls.Add(labelSurname);
            panel1.Controls.Add(textBoxCustomerName);
            panel1.Controls.Add(labelPhoneNumber);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblGender);
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
            // 
            // BtnNext
            // 
            BtnNext.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            BtnNext.Location = new System.Drawing.Point(476, 657);
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
            lblPageNumber.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            lblPageNumber.Location = new System.Drawing.Point(416, 661);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new System.Drawing.Size(58, 20);
            lblPageNumber.TabIndex = 72;
            lblPageNumber.Text = "lblPage";
            // 
            // BtnPrevious
            // 
            BtnPrevious.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            BtnPrevious.Location = new System.Drawing.Point(363, 657);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new System.Drawing.Size(49, 29);
            BtnPrevious.TabIndex = 73;
            BtnPrevious.Text = "<";
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1326, 769);
            Controls.Add(BtnNext);
            Controls.Add(lblPageNumber);
            Controls.Add(BtnPrevious);
            Controls.Add(panel1);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblCustomers);
            Controls.Add(buttonBack);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "CustomerForm";
            Text = "Customers";
            FormClosing += CustomerForm_FormClosing;
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        public System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Button BtnPrevious;
    }
}