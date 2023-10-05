using System.Windows.Forms;

namespace Library_Project
{
    partial class SearchCustomer
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
            label11 = new System.Windows.Forms.Label();
            textBoxCustomerName = new System.Windows.Forms.TextBox();
            textBoxSurname = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            buttonSearch = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label11.Location = new System.Drawing.Point(44, 108);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(119, 35);
            label11.TabIndex = 70;
            label11.Text = "Surname";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxCustomerName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxCustomerName.Location = new System.Drawing.Point(44, 67);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new System.Drawing.Size(263, 34);
            textBoxCustomerName.TabIndex = 68;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxSurname.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBoxSurname.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxSurname.Location = new System.Drawing.Point(44, 147);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new System.Drawing.Size(263, 34);
            textBoxSurname.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(30, 35, 40);
            label1.Location = new System.Drawing.Point(44, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 35);
            label1.TabIndex = 67;
            label1.Text = "Name";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSearch.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            buttonSearch.Location = new System.Drawing.Point(340, 135);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(112, 48);
            buttonSearch.TabIndex = 71;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // SearchCustomer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            ClientSize = new System.Drawing.Size(498, 246);
            Controls.Add(buttonSearch);
            Controls.Add(label11);
            Controls.Add(textBoxCustomerName);
            Controls.Add(textBoxSurname);
            Controls.Add(label1);
            Name = "SearchCustomer";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
    }
}