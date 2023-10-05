using Library_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class SearchCustomer : Form
    {
        BookLibraryContext db = new BookLibraryContext();
        public static SearchCustomer instance;

        public SearchCustomer()
        {
            InitializeComponent();
            instance = this;
        }

        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue1 = textBoxCustomerName.Text.ToLower();
            string searchValue2 = textBoxSurname.Text.ToLower();
            //string searchValue3 = comboBoxGender.SelectedItem?.ToString().ToLower();
            //string searchValue4 = textBoxPhoneNo.Text.ToLower();
            try
            {

                var filteredCustomers = db.Customers.ToList();
                if (!string.IsNullOrEmpty(searchValue1))
                {
                    filteredCustomers = filteredCustomers.Where(x => x.Name.ToLower().Contains(searchValue1)).ToList();

                }

                if (!string.IsNullOrEmpty(searchValue2))
                {
                    filteredCustomers = filteredCustomers.Where(x => x.Surname.ToLower().Contains(searchValue2)).ToList();

                }

                //if (!string.IsNullOrEmpty(searchValue3))
                //{
                //    filteredCustomers = filteredCustomers.Where(x => x.Gender.ToLower().Contains(searchValue3)).ToList();
                //}

                //if (string.IsNullOrEmpty(searchValue1) && string.IsNullOrEmpty(searchValue2) && string.IsNullOrEmpty(searchValue3))
                //{
                //    if (!string.IsNullOrEmpty(searchValue4))
                //    {
                //        filteredCustomers = filteredCustomers.Where(x => x.CreateDate.ToShortDateString().Contains(searchValue4)).ToList();
                //    }

                //}

                Form3.instance.dataGridView1.DataSource = filteredCustomers;
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            this.Hide();
        }
        
    }
}
