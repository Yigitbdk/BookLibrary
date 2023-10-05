using Library_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
    public partial class SearchReservation : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public static SearchReservation instance;
        public SearchReservation()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            string searchValue1 = textBoxBookName.Text.ToLower();
            string searchValue2 = textBoxCustomerName.Text.ToLower();
            DateTime searchValue3 = dateTimePickerFrom.Value;
            DateTime searchValue4 = dateTimePickerTo.Value;
            //BookName = new Book();

            try
            {

                var filteredReservations = db.Reservations.Include(x => x.Book).Include(x => x.Customer).ToList();
                if (!string.IsNullOrEmpty(searchValue1))
                {
                    //var BookName = db.Books.Include(Name);
                    filteredReservations = filteredReservations.Where(x => x.BookName.ToLower().Contains(searchValue1)).ToList();

                }

                if (!string.IsNullOrEmpty(searchValue2))
                {
                    filteredReservations = filteredReservations.Where(x => x.CustomerFullName.ToLower().Contains(searchValue2)).ToList();

                }

                if (string.IsNullOrEmpty(searchValue1) && string.IsNullOrEmpty(searchValue2))
                {
                    if (Convert.ToDateTime(dateTimePickerFrom.Value) <= Convert.ToDateTime(dateTimePickerTo.Value))
                    {
                        filteredReservations = filteredReservations.Where(x => searchValue3 <= x.DateTake && x.DateTake <= searchValue4).ToList();
                        //filteredReservations = filteredReservations.Where(x => searchValue3 <= x.DateReturn && x.DateReturn <= searchValue4).ToList();
                    }
                    else
                        MessageBox.Show("Please choose a valid date!");

                }

                Form4.instance.dataGridView1.DataSource = filteredReservations;
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }
    }
}
