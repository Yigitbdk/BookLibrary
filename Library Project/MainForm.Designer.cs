namespace Library_Project
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblWelcome = new System.Windows.Forms.Label();
            lblLibrary = new System.Windows.Forms.Label();
            BookFormButton = new System.Windows.Forms.Button();
            CustomerFormButton = new System.Windows.Forms.Button();
            ReservationFormButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWelcome.Location = new System.Drawing.Point(435, 133);
            lblWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(205, 26);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME TO THE";
            // 
            // lblLibrary
            // 
            lblLibrary.AutoSize = true;
            lblLibrary.Font = new System.Drawing.Font("Sylfaen", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLibrary.Location = new System.Drawing.Point(278, 163);
            lblLibrary.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblLibrary.Name = "lblLibrary";
            lblLibrary.Size = new System.Drawing.Size(568, 156);
            lblLibrary.TabIndex = 1;
            lblLibrary.Text = "LIBRARY";
            // 
            // BookFormButton
            // 
            BookFormButton.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            BookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BookFormButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BookFormButton.Location = new System.Drawing.Point(352, 335);
            BookFormButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            BookFormButton.Name = "BookFormButton";
            BookFormButton.Size = new System.Drawing.Size(144, 71);
            BookFormButton.TabIndex = 2;
            BookFormButton.Text = "Books";
            BookFormButton.UseVisualStyleBackColor = false;
            BookFormButton.Click += BookForm_Click;
            // 
            // CustomerFormButton
            // 
            CustomerFormButton.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            CustomerFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            CustomerFormButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CustomerFormButton.Location = new System.Drawing.Point(567, 335);
            CustomerFormButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            CustomerFormButton.Name = "CustomerFormButton";
            CustomerFormButton.Size = new System.Drawing.Size(153, 71);
            CustomerFormButton.TabIndex = 4;
            CustomerFormButton.Text = "Customers";
            CustomerFormButton.UseVisualStyleBackColor = false;
            CustomerFormButton.Click += CustomerForm_Click;
            // 
            // ReservationFormButton
            // 
            ReservationFormButton.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            ReservationFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ReservationFormButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ReservationFormButton.Location = new System.Drawing.Point(435, 429);
            ReservationFormButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            ReservationFormButton.Name = "ReservationFormButton";
            ReservationFormButton.Size = new System.Drawing.Size(190, 71);
            ReservationFormButton.TabIndex = 5;
            ReservationFormButton.Text = "Reservation";
            ReservationFormButton.UseVisualStyleBackColor = false;
            ReservationFormButton.Click += ReservationForm_Click;
            // 
            // BookLibraryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(1070, 687);
            Controls.Add(ReservationFormButton);
            Controls.Add(CustomerFormButton);
            Controls.Add(BookFormButton);
            Controls.Add(lblLibrary);
            Controls.Add(lblWelcome);
            ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "BookLibraryForm";
            Text = "Book Library";
            FormClosing += BookLibraryForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.Button BookFormButton;
        private System.Windows.Forms.Button CustomerFormButton;
        private System.Windows.Forms.Button ReservationFormButton;
    }
}

