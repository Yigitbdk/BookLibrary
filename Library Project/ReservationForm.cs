using Library_Project.Models;
using Library_Project.Service;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PagedList.Core;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class ReservationForm : Form
    {
        private readonly ReservationService _reservationService;
        private readonly BookService _bookService;
        private readonly CustomerService _customerService;

        private string _customerName = null;
        private string _bookName = null;
        private DateTime? _dateFrom = null;
        private DateTime? _dateTo = null;

        int indexRow;

        public ReservationForm()
        {
            InitializeComponent();
            _reservationService = new ReservationService();
            _bookService = new BookService();
            _customerService = new CustomerService();
            InitializeComboBoxes();
        }

        int pageNumber = 1;

        IPagedList<Reservation> list;




        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (list.HasPreviousPage)
            {
                pageNumber--;
                LoadDatagrid();
                lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                SetDefaultCellsValue();

            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (list.HasNextPage)
            {
                pageNumber++;
                LoadDatagrid();
                lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
                SetDefaultCellsValue();

            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            var newform = new MainForm();
            newform.Show();
            this.Hide();
        }

        private void ReservationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            try
            {
                AddCheckBoxColumnOnDataGridView();

                LoadDatagrid();

                lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }

        private void AddCheckBoxColumnOnDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dgvReservation.Columns.Insert(0, checkBoxColumn);
            SetDefaultCellsValue();
        }


        public void SetReservationStatusOnGrid()
        {

            foreach (DataGridViewRow row in dgvReservation.Rows)
            {
                DateTime borrowDate = Convert.ToDateTime(row.Cells["BorrowDate"].Value);
                DateTime borrowEndDate = Convert.ToDateTime(row.Cells["BorrowEndDate"].Value);
                DateTime? returnDate = Convert.ToDateTime(row.Cells["ReturnDate"].Value);

               
                if (returnDate > borrowEndDate)
                {
                    SetRowColor(row, Color.Blue);
                    row.Cells["StatusColumn"].Value = "Late";
                }
                else if (returnDate >= borrowDate && returnDate <= borrowEndDate)
                {
                    SetRowColor(row, Color.Green);
                    row.Cells["StatusColumn"].Value = "On Time";
                }
                
                else
                {
                    SetRowColor(row, Color.Empty);
                    row.Cells["StatusColumn"].Value = "Borrowed";
                }

            }
        }
        private void SetRowColor(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }


        public void LoadDataGridWithFilters(string bookName = null, string customerName = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            _bookName = bookName;
            _customerName = customerName;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            pageNumber = 1;
            LoadDatagrid();
        }

        public void LoadDatagrid()
        {
            list = _reservationService.GetPagedList(_bookName, _customerName, _dateFrom, _dateTo, pageNumber);
            dgvReservation.Columns.Clear();
            AddCheckBoxColumnOnDataGridView();
            dgvReservation.AutoGenerateColumns = false;

            dgvReservation.Columns.Add("BookName", "Book");
            dgvReservation.Columns["BookName"].DataPropertyName = "BookName";

            dgvReservation.Columns.Add("CustomerFullName", "Customer");
            dgvReservation.Columns["CustomerFullName"].DataPropertyName = "CustomerFullName";

            dgvReservation.Columns.Add("BorrowDate", "Borrow Date");
            dgvReservation.Columns["BorrowDate"].DataPropertyName = "BorrowDate";

            dgvReservation.Columns.Add("BorrowEndDate", "Borrow End Date");
            dgvReservation.Columns["BorrowEndDate"].DataPropertyName = "BorrowEndDate";

            dgvReservation.Columns.Add("ReturnDate", "Return Date");
            dgvReservation.Columns["ReturnDate"].DataPropertyName = "ReturnDate";

            dgvReservation.Columns.Add("StatusColumn", "Status");

            btnPrevious.Enabled = list.HasPreviousPage;
            btnNext.Enabled = list.HasNextPage;


            dgvReservation.DataSource = list.ToList();


            SetReservationStatusOnGrid();
            SetDefaultCellsValue();
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {

            var newReservation = new Reservation()
            {

                BookId = Convert.ToInt32(comboBoxBooks.SelectedValue),
                CustomerId = Convert.ToInt32(comboBoxCustomers.SelectedValue),
                BorrowDate = DateTime.Parse(dateTimePickerBorrow.Value.ToShortDateString()),
                BorrowEndDate = DateTime.Parse(dateTimePickerBorrowEnd.Value.ToShortDateString()),

            };

            foreach (DataGridViewRow row in dgvReservation.Rows)
            {

                if (_reservationService.BookHasReservation((int)comboBoxBooks.SelectedValue))
                {
                    MessageBox.Show("This book is already reserved! Please check the reservation status!");
                    return;
                }


            }

            _reservationService.AddReservation(newReservation);

            MessageBox.Show("Booked");
            LoadDatagrid();

        }

        private void InitializeComboBoxes()
        {

            comboBoxBooks.DataSource = _bookService.FillComboBox();
            comboBoxBooks.DisplayMember = "Name";
            comboBoxBooks.ValueMember = "Id";


            comboBoxCustomers.DataSource = _customerService.FillComboBox();
            comboBoxCustomers.DisplayMember = "CustomerFullName";
            comboBoxCustomers.ValueMember = "Id";

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var newform = new SearchReservationForm(this);
            newform.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGridWithFilters();
        }


        public void SetDefaultCellsValue()
        {
            foreach (DataGridViewRow row in dgvReservation.Rows)
            {
                row.Cells[0].Value = false;
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Reservation/s ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in dgvReservation.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);

                    if (isSelected)
                    {
                        _reservationService.DeleteReservation((Reservation)row.DataBoundItem);
                    }
                }

            }
            MessageBox.Show("Deleted");
            LoadDatagrid();

            if (pageNumber > list.PageCount)
            {
                pageNumber--;
                LoadDatagrid();
            }
        }


        private void dateTimePickerBorrow_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerBorrow.Value > dateTimePickerBorrowEnd.Value)
            {
                MessageBox.Show("Borrow Date can not be greater than Borrow End Date!");
                dateTimePickerBorrow.Value = dateTimePickerBorrowEnd.Value;
            }

        }

        private void dateTimePickerBorrowEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerBorrow.Value > dateTimePickerBorrowEnd.Value)
            {
                MessageBox.Show("Borrow End Date must be same or greater than Borrow Date!");
                dateTimePickerBorrowEnd.Value = DateTime.Today;
            }
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvReservation.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);

                if (isSelected)
                {
                    var newform = new ReservationReturnForm(this);
                    newform.Show();
                    return;

                }
            }

            MessageBox.Show("Reservation/s must be selected!");

        }
    }
}
