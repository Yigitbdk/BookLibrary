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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BookForm_Click(object sender, EventArgs e)
        {
            var newform = new BookForm();
            newform.Show();
            this.Hide();
        }

        private void CustomerForm_Click(object sender, EventArgs e)
        {
            var newform = new CustomerForm();
            newform.Show();
            this.Hide();
        }

        private void ReservationForm_Click(object sender, EventArgs e)
        {
            var newform = new ReservationForm();
            newform.Show();
            this.Hide();
        }


        private void BookLibraryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
