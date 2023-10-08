using Library_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Project
{
    public partial class Form3 : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public static Form3 instance;

        public Form3()
        {
            InitializeComponent();
            instance = this;
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = db.Customers.ToList();
            dataGridView1.Columns[1].Width = 131;
            dataGridView1.Columns[2].Width = 131;
            dataGridView1.Columns[3].Width = 91;
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
        private void AddButtonColumnOnDataGridView()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Rez.",
                Width = 60,
                Name = "buttonColumn"
            };
            dataGridView1.Columns.Insert(0, buttonColumn);
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
            AddButtonColumnOnDataGridView();
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

            textBoxName.Text = "";
            textBoxWriter.Text = "";
            textBoxPhoneNo.Text = "";
            comboBoxGender.Text = "";
            numericUpDownAge.Value = 0;
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

            if (MessageBox.Show("Are you sure to delete this Record/s", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        db.Customers.Remove((Customer)row.DataBoundItem);
                    }
                }
            }
            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();

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


            textBoxName.Text = "";
            textBoxWriter.Text = "";
            textBoxPhoneNo.Text = "";
            comboBoxGender.Text = "";
            numericUpDownAge.Value = 0;
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

        public void buttonSearch_Click(object sender, EventArgs e)

        {
            if (textBoxName.Text != "" || textBoxWriter.Text != "" || textBoxPhoneNo.Text != "" || comboBoxGender.Text != "")
            {
                MessageBox.Show("You must leave the right side blank.");
            }
            else
            {
                var newform = new Form1();
                newform.Show();
                this.Hide();
            }
        }

    }
}
