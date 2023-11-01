using Library_Project.Data;
using Library_Project.Models;
using Library_Project.Service;
using PagedList.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class BookForm : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        private string _bookName = null;
        private string _writer = null;
        private string _genre = null;
        private DateTime? _dateFrom = null;
        private DateTime? _dateTo = null;
        private readonly ReservationService _reservationService;
        private readonly BookService _bookService;

        public BookForm()
        {
            InitializeComponent();
            _reservationService = new ReservationService();
            _bookService = new BookService();
        }


        int indexRow;

        int pageNumber = 1;
        IPagedList<Book> list;
       


        private void BookForm_Load(object sender, EventArgs e)
        {
            try
            {
                AddCheckBoxColumnOnDataGridView();

                LoadDatagrid();


                
                dgvBooks.Columns[1].Width = 131;
                dgvBooks.Columns[2].Width = 131;
                dgvBooks.Columns[3].Width = 220;
                dgvBooks.Columns["ID"].Visible = false;
                dgvBooks.Columns["Customers"].Visible = false;
                dgvBooks.Columns["Reservations"].Visible = false;

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }

        }

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


        private void AddCheckBoxColumnOnDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dgvBooks.Columns.Insert(0, checkBoxColumn);
            SetDefaultCellsValue();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" || textBoxWriter.Text != "" || comboBoxGenre.Text != "")
            {
                MessageBox.Show("You must save your changes or press Refresh to reset them before you leave!");
            }
            else
            {
                var newform = new MainForm();
                newform.Show();
                this.Hide();
            }
        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var newBook = new Book()
            {
                Name = textBoxName.Text,
                Writer = textBoxWriter.Text,
                Genre = comboBoxGenre.Text,
                PageNumber = numericUpDownPage.Value.ToString(),
                RecordDate = DateTime.Parse(dateTimePickerRecord.Text),
                CreateDate = DateTime.Now,
            };
            _bookService.AddBook(newBook);
            LoadDatagrid();


            textBoxName.Text = "";
            textBoxWriter.Text = "";
            comboBoxGenre.Text = "";
            numericUpDownPage.Value = 0;


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to delete this Book/s ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    

                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);

                    if (isSelected)
                    {
                        if (_reservationService.BookHasReservation((int)row.Cells["Id"].Value))
                        {
                            MessageBox.Show("This book is already reserved! Please check the reservation status!");
                            return;
                        }
                        
                        _bookService.DeleteBook((Book)row.DataBoundItem);
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
        }
        public void SetDefaultCellsValue()
        {
            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                row.Cells[0].Value = false;
            }
        }
        public void LoadDataGridWithFilters(string bookName = null, string writer = null, string genre = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            _bookName = bookName;
            _writer = writer;
            _genre = genre;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            pageNumber = 1;
            LoadDatagrid();
        }

        private void LoadDatagrid()
        {

            list = _bookService.GetPagedList(_bookName, _writer, _genre, _dateFrom, _dateTo, pageNumber);
            BtnPrevious.Enabled = list.HasPreviousPage;
            BtnNext.Enabled = list.HasNextPage;
            dgvBooks.DataSource = list.ToList();
            SetDefaultCellsValue();
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);

        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                DataGridViewRow newDataRow = new DataGridViewRow();
                newDataRow = dgvBooks.Rows[indexRow];

                newDataRow.Cells[2].Value = textBoxName.Text;
                newDataRow.Cells[3].Value = textBoxWriter.Text;
                newDataRow.Cells[4].Value = comboBoxGenre.Text;
                newDataRow.Cells[5].Value = numericUpDownPage.Text;
                newDataRow.Cells[6].Value = dateTimePickerRecord.Text;

                textBoxName.Text = "";
                textBoxWriter.Text = "";
                comboBoxGenre.Text = "";
                numericUpDownPage.Value = 0;

                
                _bookService.UpdateBook((Book)newDataRow.DataBoundItem);
            }

        }

        private void dgvBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = dgvBooks.Rows[indexRow];

            textBoxName.Text = selectedRow.Cells[2].Value.ToString();
            textBoxWriter.Text = selectedRow.Cells[3].Value.ToString();
            comboBoxGenre.Text = selectedRow.Cells[4].Value.ToString();
            numericUpDownPage.Text = selectedRow.Cells[5].Value.ToString();
            dateTimePickerRecord.Text = selectedRow.Cells[6].Value.ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var newform = new SearchBookForm(this);
            newform.Show();

        }

        private void numericUpDownPage_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPage.Maximum = 9999;
            numericUpDownPage.Minimum = 0;

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGridWithFilters();
            textBoxName.Text = "";
            textBoxWriter.Text = "";
            comboBoxGenre.Text = "";
            numericUpDownPage.Value = 0;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }


    }
}
