using Library_Project.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Form4 : Form
    {
        BookLibraryContext db = new BookLibraryContext();

        public Form4()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDatagrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("DateTake", "DateTake");
            dataGridView1.Columns["DateTake"].DataPropertyName = "DateTake";
            
            dataGridView1.Columns.Add("BookName", "Book");
            dataGridView1.Columns["BookName"].DataPropertyName = "BookName";

            dataGridView1.Columns.Add("CustomerFullname", "Customer");
            dataGridView1.Columns["CustomerFullname"].DataPropertyName = "CustomerFullname";

            dataGridView1.DataSource = db.Reservations.Include(x => x.Book).Include(x => x.Customer).ToList();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            var addReservation = new Reservation()
            {

                BookId = Convert.ToInt32(comboBox2.SelectedValue),
                CustomerId = Convert.ToInt32(comboBox1.SelectedValue),
                DateTake = DateTime.Parse(dateTimePicker1.Text),
                DateReturn = DateTime.Parse(dateTimePicker2.Text),



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
            comboBox2.DataSource = db.Books.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";


            comboBox1.DataSource = db.Customers.ToList();
            comboBox2.DisplayMember = "Name" + "Surname";
            comboBox1.ValueMember = "Id";

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstname = ((Customer)e.ListItem).Name;
            string lastname = ((Customer)e.ListItem).Surname;
            e.Value = firstname + " " + lastname;
        }

       
    }
}
