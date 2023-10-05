using Library_Project.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Project
{
    public partial class Form2 : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            dataGridView1.DataSource = db.Books.ToList();
            dataGridView1.Columns[1].Width = 131;
            dataGridView1.Columns[2].Width = 131;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Customers"].Visible = false;
            dataGridView1.Columns["Reservations"].Visible = false;
        }

        int indexRow;

        private void Form2_Load(object sender, EventArgs e)
        {
            AddCheckBoxColumnOnDataGridView();
        }

        private void AddCheckBoxColumnOnDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dataGridView1.Columns.Insert(0, checkBoxColumn);
            SetDefaultCellsValue();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void fs(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addBook = new Book()
            {
                Name = textBoxName.Text,
                Writer = textBoxWriter.Text,
                Genre = comboBoxGenre.Text,
                PageNumber = numericUpDownPage.Value.ToString(),
                RecordDate = DateTime.Parse(dateTimePickerRecord.Text),
                CreateDate = DateTime.Now,
            };
            db.Books.Add(addBook);
            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    db.Books.Remove((Book)row.DataBoundItem);
                }
            }

            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();

            MessageBox.Show("Deleted");
        }

        public void SetDefaultCellsValue()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void LoadDatagrid()
        {
            dataGridView1.DataSource = db.Books.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = new DataGridViewRow();
            newDataRow = dataGridView1.Rows[indexRow];

            newDataRow.Cells[2].Value = textBoxName.Text;
            newDataRow.Cells[3].Value = textBoxWriter.Text;
            newDataRow.Cells[4].Value = comboBoxGenre.Text;
            newDataRow.Cells[5].Value = numericUpDownPage.Text;
            newDataRow.Cells[6].Value = dateTimePickerRecord.Text;
            db.SaveChanges();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = dataGridView1.Rows[indexRow];

            textBoxName.Text = selectedRow.Cells[2].Value.ToString();
            textBoxWriter.Text = selectedRow.Cells[3].Value.ToString();
            comboBoxGenre.Text = selectedRow.Cells[4].Value.ToString();
            numericUpDownPage.Text = selectedRow.Cells[5].Value.ToString();
            dateTimePickerRecord.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var newform = new SearchBook();
            newform.Show();
           
        }

        private void numericUpDownPage_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPage.Maximum = 9999;
            numericUpDownPage.Minimum = 0;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDatagrid();
            SetDefaultCellsValue();
        }
    }
}
