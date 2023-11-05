using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MidTerm
{
    public partial class FormAdmin : Form
    {
        public bool isClose = true;
        BLL_Schedule bllSchedule;
        BLL_Car bllCar;
        BLL_Customer bllCustomer;
        BindingSource scheduleList = new BindingSource();
        BindingSource carList = new BindingSource();
        BindingSource customerList = new BindingSource();

        public FormAdmin()
        {
            InitializeComponent();
            bllSchedule = new BLL_Schedule();
            bllCar = new BLL_Car();
            bllCustomer = new BLL_Customer();
            LoadData();

        }

        void LoadData()
        {
            dtgvCar.DataSource = carList;
            dtgvSchedule.DataSource = scheduleList;
            dtgvCustomer.DataSource = customerList;
            AddCustomerBinding();
            AddCarBinding();
            loadCarList();
            loadCustomerList();
            loadSchedule();
        }

        public event EventHandler CloseForm;

        private void LogoutToolAdmin_Click(object sender, EventArgs e)
        {
            CloseForm(this, new EventArgs());
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
            {
                Application.Exit();
            }

        }

        void loadSchedule()
        {
            dtgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bllSchedule.displayDTGVSchedule(scheduleList);
        }

        void loadCarList()
        {
            dtgvCar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bllCar.LoadDtgvListOfCar(carList);
        }

        void loadCustomerList()
        {
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bllCustomer.DisplayCustomerDtgv(customerList);
        }

        void AddCarBinding()
        {
            txtCarId.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtCarName.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "CarName", true, DataSourceUpdateMode.Never));
            numCarPrice.DataBindings.Add(new Binding("Value", dtgvCar.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txtCarFuel.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "FuelName", true, DataSourceUpdateMode.Never));
            txtCarAvailable.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "Status", true, DataSourceUpdateMode.Never));

        }

        void AddCustomerBinding()
        {
            txtCustomerId.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtNameCustomer.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "CustomerName", true, DataSourceUpdateMode.Never));
            txtGender.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Gender", true, DataSourceUpdateMode.Never));
            txtPhoneNum.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txtCCCD.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "CCCD", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Address", true, DataSourceUpdateMode.Never));
        }

        private void btnReadSchedule_Click(object sender, EventArgs e)
        {
            loadSchedule();
        }

        private void btnReadCarList_Click_1(object sender, EventArgs e)
        {
            loadCarList();

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CarDTO car = new CarDTO();
            car.CarName = txtCarName.Text;
            car.Price = (double)numCarPrice.Value;
            car.Description = txtDescription.Text;

            bllCar.AddCar(txtCarFuel.Text, car);
        }

        private void btnReadCustomer_Click(object sender, EventArgs e)
        {

            loadCustomerList();

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

            bllCar.DeleteCar(int.Parse(txtCarId.Text));
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Customer result = bllCustomer.searchCustomerByName(txtSearchCustomer.Text);
            if (result != null)
            {
                txtNameCustomer.Text = result.CustomerName;
                txtGender.Text = result.Gender;
                txtCCCD.Text = result.CCCD;
                txtPhoneNum.Text = result.PhoneNumber;
                txtAddress.Text = result.Address;
                customerList.DataSource = result;
                txtSearchCustomer.Clear();
            }
            else
            {
                MessageBox.Show("Người dùng không tồn tại!");
                txtSearchCustomer.Clear();
            }
        }
    }
}
