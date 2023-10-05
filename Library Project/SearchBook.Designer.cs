namespace Library_Project
{
    partial class SearchBook
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelRecord = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxWriter = new System.Windows.Forms.TextBox();
            comboBoxGenre = new System.Windows.Forms.ComboBox();
            dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            buttonSearch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label2.Location = new System.Drawing.Point(29, 16);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 35);
            label2.TabIndex = 39;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label3.Location = new System.Drawing.Point(23, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 35);
            label3.TabIndex = 40;
            label3.Text = "Writer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label4.Location = new System.Drawing.Point(27, 184);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 35);
            label4.TabIndex = 41;
            label4.Text = "Genre";
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelRecord.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            labelRecord.Location = new System.Drawing.Point(389, 16);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new System.Drawing.Size(152, 35);
            labelRecord.TabIndex = 42;
            labelRecord.Text = "From Date:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxName.Location = new System.Drawing.Point(29, 54);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(262, 34);
            textBoxName.TabIndex = 43;
            // 
            // textBoxWriter
            // 
            textBoxWriter.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxWriter.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxWriter.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxWriter.Location = new System.Drawing.Point(29, 135);
            textBoxWriter.Name = "textBoxWriter";
            textBoxWriter.Size = new System.Drawing.Size(262, 34);
            textBoxWriter.TabIndex = 44;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            comboBoxGenre.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comboBoxGenre.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "True Crime", "Biographies and Autobiographies", "Novel", "Poetry", "Action and Adventure", "Comic Book", "Manga", "Detective and Mystery", "Fantasy", "Historical Fiction", "Horror", "Romance", "Science Fiction", "Cookbooks", "Essays", "History" });
            comboBoxGenre.Location = new System.Drawing.Point(29, 222);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new System.Drawing.Size(262, 34);
            comboBoxGenre.TabIndex = 45;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePickerFrom.CalendarTitleForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerFrom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePickerFrom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePickerFrom.Location = new System.Drawing.Point(389, 54);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new System.Drawing.Size(262, 34);
            dateTimePickerFrom.TabIndex = 46;
            dateTimePickerFrom.Value = new System.DateTime(2023, 9, 1, 0, 0, 0, 0);
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(389, 211);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(112, 48);
            buttonSearch.TabIndex = 51;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label1.Location = new System.Drawing.Point(389, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 35);
            label1.TabIndex = 52;
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
            dateTimePickerTo.Location = new System.Drawing.Point(389, 135);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new System.Drawing.Size(262, 34);
            dateTimePickerTo.TabIndex = 53;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            ClientSize = new System.Drawing.Size(680, 297);
            Controls.Add(label1);
            Controls.Add(dateTimePickerTo);
            Controls.Add(buttonSearch);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(labelRecord);
            Controls.Add(textBoxName);
            Controls.Add(textBoxWriter);
            Controls.Add(comboBoxGenre);
            Controls.Add(dateTimePickerFrom);
            Name = "SearchBook";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}