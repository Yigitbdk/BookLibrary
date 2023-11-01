using Library_Project.Data;
using Library_Project.Service;
using System;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class SearchReservationForm : Form
    {

        private readonly ReservationForm _reservationForm;

        public SearchReservationForm(ReservationForm reservation)
        {
            InitializeComponent();
            _reservationForm = reservation;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string bookName = textBoxBookName.Text.ToLower();
                string customerName = textBoxCustomerName.Text.ToLower();
                DateTime dateFrom = dateTimePickerFrom.Value;
                DateTime dateTo = dateTimePickerTo.Value;


                _reservationForm.LoadDataGridWithFilters(bookName, customerName, dateFrom, dateTo);

                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("From Date can not be greater than To Date!");
                dateTimePickerFrom.Value = dateTimePickerTo.Value;
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show("To Date must be same or greater than From Date!");
                dateTimePickerTo.Value = DateTime.Today;
            }
        }
    }
}
