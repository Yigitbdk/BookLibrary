using Library_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class Form4 : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public static Form4 instance;

        public Form4()
        {
            InitializeComponent();
            instance = this;
            LoadDatagrid();
            comboBox_Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

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

        //public void AddStatusColumnOnDataGridView()
        //{
        //    dataGridView1.Columns.Add("StatusColumn", "Status");


        //}
        private void reservationStatus()
        {
            dataGridView1.Columns.Add("StatusColumn", "Status");
            //if (dataGridView1.Rows.Count <= 0)
            //{
            //    MessageBox.Show("Datagridview is empty!");
            //    return;
            //}

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime value = Convert.ToDateTime(row.Cells["DateReturn"].Value);


                int result = DateTime.Compare(value, DateTime.Today);

                if (result < 0) //value is earlier than citeria
                {
                    ColorRow(row, Color.Red);
                    row.Cells["StatusColumn"].Value = "Late";
                }
                else if (result == 0) //Value is equal to citeria
                {
                    ColorRow(row, Color.Blue);
                    row.Cells["StatusColumn"].Value = "Last Day";
                }
                else if (result > 0) //value is later than citeria
                {
                    ColorRow(row, Color.Green);
                    row.Cells["StatusColumn"].Value = "On Time";
                }

            }
        }
        private void ColorRow(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadDatagrid()
        {
            dataGridView1.Columns.Clear();
            AddCheckBoxColumnOnDataGridView();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("BookName", "Book");
            dataGridView1.Columns["BookName"].DataPropertyName = "BookName";

            dataGridView1.Columns.Add("CustomerFullname", "Customer");
            dataGridView1.Columns["CustomerFullname"].DataPropertyName = "CustomerFullname";

            dataGridView1.Columns.Add("DateTake", "Date Take");
            dataGridView1.Columns["DateTake"].DataPropertyName = "DateTake";

            dataGridView1.Columns.Add("DateReturn", "Date Return");
            dataGridView1.Columns["DateReturn"].DataPropertyName = "DateReturn";

            dataGridView1.DataSource = db.Reservations.Include(x => x.Book).Include(x => x.Customer).ToList();

            reservationStatus();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            var addReservation = new Reservation()
            {

                BookId = Convert.ToInt32(comboBox2.SelectedValue),
                CustomerId = Convert.ToInt32(comboBox1.SelectedValue),
                DateTake = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),
                DateReturn = DateTime.Parse(dateTimePicker2.Value.ToShortDateString()),

            };
            db.Reservations.Add(addReservation);
            db.SaveChanges();
            LoadDatagrid();


            MessageBox.Show("Booked");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox_Listele()
        {

            comboBox2.DataSource = db.Books.OrderBy(x => x.Name).ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";


            comboBox1.DataSource = db.Customers.OrderBy(x => x.Name).ToList();
            comboBox2.DisplayMember = "Name" + "Surname";
            comboBox1.ValueMember = "Id";

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstname = ((Customer)e.ListItem).Name;
            string lastname = ((Customer)e.ListItem).Surname;
            e.Value = firstname + " " + lastname;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var newform = new SearchReservation();
            newform.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDatagrid();
            SetDefaultCellsValue();
        }


        public void SetDefaultCellsValue()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = false;
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    db.Reservations.Remove((Reservation)row.DataBoundItem);
                }
            }

            db.SaveChanges();
            LoadDatagrid();
            SetDefaultCellsValue();

            MessageBox.Show("Deleted");
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            reservationStatus();
        }
    }
}
