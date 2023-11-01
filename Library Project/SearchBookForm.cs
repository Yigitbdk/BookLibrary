using System;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class SearchBookForm : Form
    {
        private readonly BookForm _bookForm;

        public SearchBookForm(BookForm bookForm)
        {
            InitializeComponent();
            _bookForm = bookForm;
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string bookName = textBoxName.Text.ToLower();
                string writer = textBoxWriter.Text.ToLower();
                string genre = comboBoxGenre.SelectedItem?.ToString().ToLower();
                DateTime dateFrom = dateTimePickerFrom.Value;
                DateTime dateTo = dateTimePickerTo.Value;

                _bookForm.LoadDataGridWithFilters(bookName, writer, genre, dateFrom, dateTo);


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
                MessageBox.Show("From Date can not be greater than To Date");
                dateTimePickerFrom.Value = dateTimePickerTo.Value;
            }
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                dateTimePickerTo.Value = DateTime.Today;
                MessageBox.Show("To Date must be same or greater than From Date");

            }
        }
    }
}
