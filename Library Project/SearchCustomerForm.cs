using System;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class SearchCustomerForm : Form
    {
        private readonly CustomerForm _customerForm;

        public SearchCustomerForm(CustomerForm customer)
        {
            InitializeComponent();
            _customerForm = customer;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
            try
            {
                string name = textBoxCustomerName.Text.ToLower();
                string surname = textBoxSurname.Text.ToLower();


                _customerForm.LoadDataGridWithFilters(name, surname);

                Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            this.Hide();
        }
        
    }
}
