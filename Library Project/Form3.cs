using Library_Project.Models;
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
    public partial class Form3 : Form
    {
        BookLibraryContext db = new BookLibraryContext();

        public Form3()
        {
            InitializeComponent();
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = db.Customers.ToList();
            dataGridView1.Columns[1].Width = 131;
            dataGridView1.Columns[2].Width = 131;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns["ID"].Visible = false;
        }

        int indexRow;

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void textBoxCustomers_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AddCheckBoxColumnOnDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var addCustomer = new Customer()
            {
                Name = textBoxCustomerName.Text,
                Surname = textBoxSurname.Text,
                TelNo = textBoxPhoneNo.Text,
                Gender = comboBoxGender.Text,
                Age = Convert.ToInt16(numericUpDownAge.Value),
                CreateDate = DateTime.Now,
            };
            db.Customers.Add(addCustomer);
            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();
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
            dataGridView1.DataSource = db.Customers.ToList();
        }


        private void textBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    db.Customers.Remove((Customer)row.DataBoundItem);
                }
            }

            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();

            MessageBox.Show("Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = new DataGridViewRow();
            newDataRow = dataGridView1.Rows[indexRow];

            newDataRow.Cells[2].Value = textBoxCustomerName.Text;
            newDataRow.Cells[3].Value = textBoxSurname.Text;
            newDataRow.Cells[4].Value = Convert.ToInt16(numericUpDownAge.Value);
            newDataRow.Cells[5].Value = comboBoxGender.Text;
            newDataRow.Cells[7].Value = textBoxPhoneNo.Text;
            db.SaveChanges();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDatagrid();
            SetDefaultCellsValue();
        }

        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAge.Maximum = 9999;
            numericUpDownAge.Minimum = 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue1 = textBoxCustomerName.Text.ToLower();
            string searchValue2 = textBoxSurname.Text.ToLower();
            string searchValue3 = comboBoxGender.SelectedItem?.ToString().ToLower();
            string searchValue4 = textBoxPhoneNo.Text.ToLower();
            try
            {

                var filteredCustomers = db.Customers.ToList();
                if (!string.IsNullOrEmpty(searchValue1))
                {
                    filteredCustomers = filteredCustomers.Where(x => x.Name.ToLower().Contains(searchValue1)).ToList();

                }

                if (!string.IsNullOrEmpty(searchValue2))
                {
                    filteredCustomers = filteredCustomers.Where(x => x.Surname.ToLower().Contains(searchValue2)).ToList();

                }

                if (!string.IsNullOrEmpty(searchValue3))
                {
                    filteredCustomers = filteredCustomers.Where(x => x.Gender.ToLower().Contains(searchValue3)).ToList();
                }

                if (string.IsNullOrEmpty(searchValue1) && string.IsNullOrEmpty(searchValue2) && string.IsNullOrEmpty(searchValue3))
                {
                    if (!string.IsNullOrEmpty(searchValue4))
                    {
                        filteredCustomers = filteredCustomers.Where(x => x.CreateDate.ToShortDateString().Contains(searchValue4)).ToList();
                    }

                }

                dataGridView1.DataSource = filteredCustomers;
                SetDefaultCellsValue();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
