using Library_Project.Models;
using Library_Project.Service;
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
    public partial class ReservationReturnForm : Form
    {
        private readonly ReservationService _reservationService;
        private readonly ReservationForm _reservationForm;


        int indexRow;

        public ReservationReturnForm(ReservationForm reservation)
        {
            InitializeComponent();
            _reservationService = new ReservationService();
            _reservationForm = reservation;
        }

        
        private void BtnReturn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in _reservationForm.dgvReservation.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkboxColumn"].Value);

                if (isSelected)
                {
                    if (dateTimePicker.Value < Convert.ToDateTime(row.Cells["BorrowDate"].Value))
                    {
                        MessageBox.Show("Return date must greater than the borrow date!");
                        return;
                    }

                    row.Cells["ReturnDate"].Value = dateTimePicker.Value.ToShortDateString();
                    _reservationForm.SetReservationStatusOnGrid();
                    _reservationService.ReturnBook((Reservation)row.DataBoundItem);
                }
            }

            Close();

        }
    }
}
