using MidTerm.BLL;
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
        BLL_BillInfo bllBillInfo;
        BindingSource scheduleList = new BindingSource();
        BindingSource carList = new BindingSource();
        BindingSource customerList = new BindingSource();

        public FormAdmin()
        {
            InitializeComponent();
            bllSchedule = new BLL_Schedule();
            bllCar = new BLL_Car();
            bllCustomer = new BLL_Customer();
            bllBillInfo = new BLL_BillInfo();
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

        #region load datagridview
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
        #endregion

        #region Binding data
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
        #endregion

        #region Schedule 
        private void btnReadSchedule_Click(object sender, EventArgs e)
        {
            loadSchedule();
        }
        #endregion

        #region Car
        private void btnReadCarList_Click_1(object sender, EventArgs e)
        {
            loadCarList();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CarDTO car = new CarDTO();
            if((double)numCarPrice.Value < 0)
            {
                MessageBox.Show("Giá xe cần phải lớn hơn 0");
                numCarPrice.Value = 1;
            }
            car.CarName = txtCarName.Text;
            car.Price = (double)numCarPrice.Value;
            car.Description = txtDescription.Text;

            bllCar.AddCar(txtCarFuel.Text, car);
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

            bllCar.DeleteCar(int.Parse(txtCarId.Text));
            loadCarList();
        }
        #endregion

        #region Customer
        private void btnReadCustomer_Click(object sender, EventArgs e)
        {
            loadCustomerList();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên cần tìm kiếm ");
                txtSearchCustomer.Focus();
                loadCustomerList();
                return;
            }
            var result = bllCustomer.searchCustomerByName(txtSearchCustomer.Text);
            if (result.Count != 0)
            {
                dtgvCustomer.DataSource = null;
                customerList.Clear();
                customerList.DataSource = result;
                dtgvCustomer.DataSource = customerList;
            }
            else
            {
                MessageBox.Show("Người dùng không tồn tại!");
                txtSearchCustomer.Clear();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "" && txtCCCD.Text == "")
            {
                MessageBox.Show("Cần điền ít nhất thông tin tên hoặc cccd để thêm mới khách hàng!");
                txtNameCustomer.Focus();
            }
            else
            {
                bllCustomer.addCustomer(txtNameCustomer.Text, txtCCCD.Text, txtPhoneNum.Text, txtGender.Text, txtAddress.Text);
                loadCustomerList();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                bllCustomer.deleteCustomer(int.Parse(txtCustomerId.Text));
                loadCustomerList();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region Bill
        #endregion
    }
}
