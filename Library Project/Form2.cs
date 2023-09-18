using Library_Project.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class Form2 : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Books.ToList();           
        }
        //Test

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
        private void BOOKS_Click(object sender, EventArgs e)
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

            MessageBox.Show("Added");
        }

        private void textBoxPageNumber_TextChanged(object sender, EventArgs e)
        {

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

            //db.Books.Remove(new Book() { Id = 10 });
            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();

            MessageBox.Show("Deleted");
        }

        private void SetDefaultCellsValue()
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

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
