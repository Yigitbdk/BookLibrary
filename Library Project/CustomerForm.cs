using Library_Project.Data;
using Library_Project.Models;
using Library_Project.Service;
using PagedList.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class CustomerForm : Form
    {
        BookLibraryContext db = new BookLibraryContext();

        private string _name = null;
        private string _surname = null;
        private readonly ReservationService _reservationService;
        private readonly CustomerService _customerService;
        public static CustomerForm instance;

        public CustomerForm()
        {
            InitializeComponent();
            _reservationService = new ReservationService();
            _customerService = new CustomerService();
            instance = this;
        }

        int indexRow;

        int pageNumber = 1;
        IPagedList<Customer> list;


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
            if (textBoxCustomerName.Text != "" || textBoxSurname.Text != "" || textBoxPhoneNo.Text != "")
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

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void AddButtonColumnOnDataGridView()
        {
            //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            //{
            //    HeaderText = "Rez.",
            //    Width = 30,
            //    Name = "buttonColumn"
            //};
            //dataGridView1.Columns.Insert(1, buttonColumn);
        }

        private void AddCheckBoxColumnOnDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30,
                Name = "checkBoxColumn"
            };
            dgvCustomers.Columns.Insert(0, checkBoxColumn);
            SetDefaultCellsValue();
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {

            try
            {
                AddCheckBoxColumnOnDataGridView();

                LoadDatagrid();


                AddButtonColumnOnDataGridView();

                dgvCustomers.Columns[1].Width = 131;
                dgvCustomers.Columns[2].Width = 131;
                dgvCustomers.Columns[3].Width = 91;
                dgvCustomers.Columns["ID"].Visible = false;
                dgvCustomers.Columns["CustomerFullname"].Visible = false;




            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer()
            {
                Name = textBoxCustomerName.Text,
                Surname = textBoxSurname.Text,
                TelNo = textBoxPhoneNo.Text,
                Gender = comboBoxGender.Text,
                Age = Convert.ToInt16(numericUpDownAge.Value),
                CreateDate = DateTime.Now,
            };
            _customerService.AddCustomer(newCustomer);
            LoadDatagrid();


            textBoxCustomerName.Text = "";
            textBoxSurname.Text = "";
            textBoxPhoneNo.Text = "";
            comboBoxGender.Text = "";
            numericUpDownAge.Value = 0;
        }

        private void SetDefaultCellsValue()
        {
            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                row.Cells[0].Value = false;
            }
        }
        public void LoadDataGridWithFilters(string name = null, string surname = null)
        {
            _name = name;
            _surname = surname;
            pageNumber = 1;
            LoadDatagrid();
        }

        private void LoadDatagrid()
        {
            list = _customerService.GetPagedList(_name, _surname, pageNumber);
            BtnPrevious.Enabled = list.HasPreviousPage;
            BtnNext.Enabled = list.HasNextPage;
            dgvCustomers.DataSource = list.ToList();
            SetDefaultCellsValue();
            lblPageNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);

            

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this Customer/s", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                foreach (DataGridViewRow row in dgvCustomers.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);

                    if (isSelected)
                    {

                        if (_reservationService.CustomerHasReservation((int)row.Cells["Id"].Value))
                        {
                            MessageBox.Show("This person has reserved books! Please check the reservation status!");
                            return;
                        }
                        _customerService.DeleteCustomer((Customer)row.DataBoundItem);


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
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (BookLibraryContext db = new BookLibraryContext())
            {
                DataGridViewRow newDataRow = new DataGridViewRow();
                newDataRow = dgvCustomers.Rows[indexRow];

                newDataRow.Cells[2].Value = textBoxCustomerName.Text;
                newDataRow.Cells[3].Value = textBoxSurname.Text;
                newDataRow.Cells[4].Value = Convert.ToInt16(numericUpDownAge.Value);
                newDataRow.Cells[5].Value = comboBoxGender.Text;
                newDataRow.Cells[7].Value = textBoxPhoneNo.Text;


                textBoxCustomerName.Text = "";
                textBoxSurname.Text = "";
                textBoxPhoneNo.Text = "";
                comboBoxGender.Text = "";
                numericUpDownAge.Value = 0;

                _customerService.UpdateCustomer((Customer)newDataRow.DataBoundItem);


            }


        }

        private void dgvCustomers_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow selectedRow = new DataGridViewRow();
            selectedRow = dgvCustomers.Rows[indexRow];

            textBoxCustomerName.Text = selectedRow.Cells[2].Value.ToString();
            textBoxSurname.Text = selectedRow.Cells[3].Value.ToString();
            numericUpDownAge.Text = selectedRow.Cells[4].Value.ToString();
            comboBoxGender.Text = selectedRow.Cells[5].Value.ToString();
            textBoxPhoneNo.Text = selectedRow.Cells[7].Value.ToString();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGridWithFilters();

            textBoxCustomerName.Text = "";
            textBoxSurname.Text = "";
            textBoxPhoneNo.Text = "";
            comboBoxGender.Text = "";
            numericUpDownAge.Value = 0;
        }

        private void numericUpDownAge_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAge.Maximum = 9999;
            numericUpDownAge.Minimum = 0;
        }

        public void BtnSearch_Click(object sender, EventArgs e)
        {
            var newform = new SearchCustomerForm(this);
            newform.Show();

        }

        

    }
}
