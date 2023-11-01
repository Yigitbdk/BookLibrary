namespace Library_Project
{
    partial class ReservationReturnForm
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
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            lblReturnDate = new System.Windows.Forms.Label();
            buttonReturn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            dateTimePicker.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dateTimePicker.Location = new System.Drawing.Point(32, 86);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(262, 34);
            dateTimePicker.TabIndex = 58;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            lblReturnDate.Location = new System.Drawing.Point(32, 31);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new System.Drawing.Size(171, 35);
            lblReturnDate.TabIndex = 59;
            lblReturnDate.Text = "Return Date:";
            // 
            // buttonReturn
            // 
            buttonReturn.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonReturn.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonReturn.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonReturn.Location = new System.Drawing.Point(337, 57);
            buttonReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new System.Drawing.Size(187, 63);
            buttonReturn.TabIndex = 60;
            buttonReturn.Text = "Return Book";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += BtnReturn_Click;
            // 
            // ReservationReturnForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            ClientSize = new System.Drawing.Size(547, 159);
            Controls.Add(buttonReturn);
            Controls.Add(lblReturnDate);
            Controls.Add(dateTimePicker);
            Name = "ReservationReturnForm";
            Text = "Reservation Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button buttonReturn;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}