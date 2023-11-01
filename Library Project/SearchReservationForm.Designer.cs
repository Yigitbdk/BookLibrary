namespace Library_Project
{
    partial class SearchReservationForm
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
            buttonSearch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            labelRecord = new System.Windows.Forms.Label();
            dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            textBoxBookName = new System.Windows.Forms.TextBox();
            textBoxCustomerName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(482, 217);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(112, 48);
            buttonSearch.TabIndex = 52;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += BtnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label1.Location = new System.Drawing.Point(332, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 35);
            label1.TabIndex = 56;
            label1.Text = "To Date:";
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerTo.CalendarTitleForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerTo.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerTo.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePickerTo.Location = new System.Drawing.Point(332, 154);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new System.Drawing.Size(262, 34);
            dateTimePickerTo.TabIndex = 57;
            dateTimePickerTo.ValueChanged += dateTimePickerTo_ValueChanged;
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelRecord.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            labelRecord.Location = new System.Drawing.Point(332, 24);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new System.Drawing.Size(152, 35);
            labelRecord.TabIndex = 54;
            labelRecord.Text = "From Date:";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerFrom.CalendarTitleForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerFrom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerFrom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePickerFrom.Location = new System.Drawing.Point(332, 62);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new System.Drawing.Size(262, 34);
            dateTimePickerFrom.TabIndex = 55;
            dateTimePickerFrom.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            dateTimePickerFrom.ValueChanged += dateTimePickerFrom_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label2.Location = new System.Drawing.Point(26, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 35);
            label2.TabIndex = 58;
            label2.Text = "Book Name";
            // 
            // textBoxBookName
            // 
            textBoxBookName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxBookName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxBookName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxBookName.Location = new System.Drawing.Point(26, 62);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new System.Drawing.Size(262, 34);
            textBoxBookName.TabIndex = 61;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxCustomerName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxCustomerName.Location = new System.Drawing.Point(26, 155);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new System.Drawing.Size(263, 34);
            textBoxCustomerName.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label5.Location = new System.Drawing.Point(26, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(209, 35);
            label5.TabIndex = 76;
            label5.Text = "Customer Name";
            // 
            // SearchReservation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            ClientSize = new System.Drawing.Size(616, 286);
            Controls.Add(textBoxCustomerName);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxBookName);
            Controls.Add(label1);
            Controls.Add(dateTimePickerTo);
            Controls.Add(labelRecord);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(buttonSearch);
            Name = "SearchReservation";
            Text = "Search Reservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label label5;
    }
}