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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            textBoxId = new System.Windows.Forms.TextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            textBoxWriter = new System.Windows.Forms.TextBox();
            textBoxGenre = new System.Windows.Forms.TextBox();
            textBoxPageNumber = new System.Windows.Forms.TextBox();
            textBoxDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BOOKS
            // 
            BOOKS.AutoSize = true;
            BOOKS.Font = new System.Drawing.Font("Sylfaen", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BOOKS.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            BOOKS.Location = new System.Drawing.Point(338, 23);
            BOOKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BOOKS.Name = "BOOKS";
            BOOKS.Size = new System.Drawing.Size(246, 84);
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
            button3.Location = new System.Drawing.Point(29, 447);
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
            dataGridView1.Location = new System.Drawing.Point(29, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(687, 283);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button1.Location = new System.Drawing.Point(147, 447);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(185, 48);
            button1.TabIndex = 13;
            button1.Text = "Add New Book";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label1.Location = new System.Drawing.Point(747, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 22);
            label1.TabIndex = 20;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label2.Location = new System.Drawing.Point(747, 283);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 22);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label3.Location = new System.Drawing.Point(747, 183);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 22);
            label3.TabIndex = 22;
            label3.Text = "Writer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label4.Location = new System.Drawing.Point(747, 333);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 22);
            label4.TabIndex = 23;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label5.Location = new System.Drawing.Point(747, 232);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 22);
            label5.TabIndex = 24;
            label5.Text = "PageNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            label6.Location = new System.Drawing.Point(747, 383);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 22);
            label6.TabIndex = 25;
            label6.Text = "Date";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.FromArgb(245, 179, 1);
            button2.Location = new System.Drawing.Point(338, 447);
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
            button4.Location = new System.Drawing.Point(529, 447);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(185, 48);
            button4.TabIndex = 27;
            button4.Text = "Save to the Database";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBoxId
            // 
            textBoxId.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxId.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxId.Location = new System.Drawing.Point(747, 407);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new System.Drawing.Size(144, 23);
            textBoxId.TabIndex = 30;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxName.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxName.Location = new System.Drawing.Point(747, 157);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(144, 23);
            textBoxName.TabIndex = 31;
            // 
            // textBoxWriter
            // 
            textBoxWriter.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxWriter.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxWriter.Location = new System.Drawing.Point(747, 307);
            textBoxWriter.Name = "textBoxWriter";
            textBoxWriter.Size = new System.Drawing.Size(144, 23);
            textBoxWriter.TabIndex = 32;
            // 
            // textBoxGenre
            // 
            textBoxGenre.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxGenre.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxGenre.Location = new System.Drawing.Point(747, 257);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new System.Drawing.Size(144, 23);
            textBoxGenre.TabIndex = 33;
            // 
            // textBoxPageNumber
            // 
            textBoxPageNumber.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxPageNumber.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxPageNumber.Location = new System.Drawing.Point(747, 207);
            textBoxPageNumber.Name = "textBoxPageNumber";
            textBoxPageNumber.Size = new System.Drawing.Size(144, 23);
            textBoxPageNumber.TabIndex = 34;
            textBoxPageNumber.TextChanged += textBoxPageNumber_TextChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = System.Drawing.Color.FromArgb(42, 46, 52);
            textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxDate.ForeColor = System.Drawing.Color.FromArgb(254, 208, 83);
            textBoxDate.Location = new System.Drawing.Point(747, 357);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new System.Drawing.Size(144, 23);
            textBoxDate.TabIndex = 35;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 35, 40);
            ClientSize = new System.Drawing.Size(937, 519);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxPageNumber);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxWriter);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label BOOKS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}