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
    public partial class SearchBook : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public static SearchBook instance;
        public SearchBook()
        {
            InitializeComponent();
            instance = this;
        }

        //public static bool Between(DateTime input, DateTime date1, DateTime date2)
        //{
        //    return (input >= date1 && input <= date2);
        //}

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue1 = textBoxName.Text.ToLower();
            string searchValue2 = textBoxWriter.Text.ToLower();
            string searchValue3 = comboBoxGenre.SelectedItem?.ToString().ToLower();
            DateTime searchValue4 = dateTimePickerFrom.Value;
            DateTime searchValue5 = dateTimePickerTo.Value;


            try
            {

                var filteredBooks = db.Books.ToList();
                if (!string.IsNullOrEmpty(searchValue1))
                {
                    filteredBooks = filteredBooks.Where(x => x.Name.ToLower().Contains(searchValue1)).ToList();

                }

                if (!string.IsNullOrEmpty(searchValue2))
                {
                    filteredBooks = filteredBooks.Where(x => x.Writer.ToLower().Contains(searchValue2)).ToList();

                }

                if (!string.IsNullOrEmpty(searchValue3))
                {
                    filteredBooks = filteredBooks.Where(x => x.Genre.ToLower().Contains(searchValue3)).ToList();
                }

                if (string.IsNullOrEmpty(searchValue1) && string.IsNullOrEmpty(searchValue2) && string.IsNullOrEmpty(searchValue3))
                {
                    if (Convert.ToDateTime(dateTimePickerFrom.Value) <=  Convert.ToDateTime(dateTimePickerTo.Value))
                    {
                       
                        filteredBooks = filteredBooks.Where(x => searchValue4 <= x.RecordDate && x.RecordDate <= searchValue5).ToList();
                        
                    }
                    else
                        MessageBox.Show("Please choose a valid date!");

                }

                Form2.instance.dataGridView1.DataSource = filteredBooks;
                Form2.instance.SetDefaultCellsValue();
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
