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
            button5 = new System.Windows.Forms.Button();
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
            BOOKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BOOKS.Location = new System.Drawing.Point(337, 9);
            BOOKS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BOOKS.Name = "BOOKS";
            BOOKS.Size = new System.Drawing.Size(266, 73);
            BOOKS.TabIndex = 3;
            BOOKS.Text = "BOOKS";
            BOOKS.Click += BOOKS_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(14, 447);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(100, 59);
            button3.TabIndex = 4;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(14, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(643, 280);
            dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(194, 447);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(127, 48);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(685, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 15);
            label1.TabIndex = 20;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(800, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 15);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(685, 176);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 22;
            label3.Text = "Writer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(800, 176);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 15);
            label4.TabIndex = 23;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(683, 229);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 15);
            label5.TabIndex = 24;
            label5.Text = "PageNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(800, 229);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 15);
            label6.TabIndex = 25;
            label6.Text = "Date";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(337, 447);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(135, 48);
            button2.TabIndex = 26;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(492, 447);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(143, 48);
            button4.TabIndex = 27;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(662, 447);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(146, 48);
            button5.TabIndex = 28;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new System.Drawing.Point(683, 150);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new System.Drawing.Size(98, 23);
            textBoxId.TabIndex = 30;
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(787, 150);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(98, 23);
            textBoxName.TabIndex = 31;
            // 
            // textBoxWriter
            // 
            textBoxWriter.Location = new System.Drawing.Point(683, 203);
            textBoxWriter.Name = "textBoxWriter";
            textBoxWriter.Size = new System.Drawing.Size(98, 23);
            textBoxWriter.TabIndex = 32;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new System.Drawing.Point(787, 203);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new System.Drawing.Size(98, 23);
            textBoxGenre.TabIndex = 33;
            // 
            // textBoxPageNumber
            // 
            textBoxPageNumber.Location = new System.Drawing.Point(683, 247);
            textBoxPageNumber.Name = "textBoxPageNumber";
            textBoxPageNumber.Size = new System.Drawing.Size(98, 23);
            textBoxPageNumber.TabIndex = 34;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new System.Drawing.Point(787, 247);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new System.Drawing.Size(98, 23);
            textBoxDate.TabIndex = 35;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(937, 519);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxPageNumber);
            Controls.Add(textBoxGenre);
            Controls.Add(textBoxWriter);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(button5);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWriter;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPageNumber;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}