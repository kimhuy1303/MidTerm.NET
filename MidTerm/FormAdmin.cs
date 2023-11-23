using MidTerm.BLL;
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
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization;
using OfficeOpenXml.Drawing.Chart;

namespace MidTerm
{
    public partial class FormAdmin : Form
    {
        public bool isClose = true;
        BLL_Schedule bllSchedule;
        BLL_Car bllCar;
        BLL_Customer bllCustomer;
        BLL_BillInfo bllBillInfo;
        BLL_Fuel bllFuel;
        BLL_Bill bllBill;
        BindingSource scheduleList = new BindingSource();
        BindingSource carList = new BindingSource();
        BindingSource customerList = new BindingSource();
        BindingSource billInfoList = new BindingSource();
        public FormAdmin()
        {
            InitializeComponent();
            bllSchedule = new BLL_Schedule();
            bllCar = new BLL_Car();
            bllCustomer = new BLL_Customer();
            bllBillInfo = new BLL_BillInfo();
            bllFuel = new BLL_Fuel();
            bllBill = new BLL_Bill();
            LoadData();

        }

        void LoadData()
        {
            dtgvCar.DataSource = carList;
            dtgvSchedule.DataSource = scheduleList;
            dtgvCustomer.DataSource = customerList;
            dtgvBillInfo.DataSource = billInfoList;
            loadDashboard();
            AddCustomerBinding();
            AddCarBinding();
            AddBillBinding();
            AddScheduleBinding();
            loadCarList();
            loadCustomerList();
            loadSchedule();
            loadBillInfo();
        }

        public event EventHandler CloseForm;

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClose)
            {
                System.Windows.Forms.Application.Exit();
            }
            FormChuongTrinh f = new FormChuongTrinh();
            f.reset(sender, e);
        }

        #region Dashboard
        void loadDashboard()
        {
            var totalRenevue = bllBill.getTotalRenevue();
            lbRevenue.Text = Math.Ceiling(totalRenevue).ToString() + "vnđ";
            var totalCars = bllCar.CarsTotal();
            lbCars.Text = totalCars.ToString() + " chiếc";
            var totalCustomers = bllCustomer.GetCustomersTotal();
            lbCustomers.Text = totalCustomers.ToString() + " khách hàng";
            var totalBills = bllBill.getTotalBills();
            lbBills.Text = totalBills.ToString() + " đơn";
        }

        void loadPieChart(string key)
        {
            chartRevenuePie.DataSource = bllBillInfo.getRevenueByCar(key);
            chartRevenuePie.Series["Revenue"].XValueMember = "carName";
            chartRevenuePie.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartRevenuePie.Series["Revenue"].YValueMembers = "carRevenue";
            chartRevenuePie.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        void loadChart(int month)
        {
            chartRevenue.Series["Revenue"].Points.Clear();
            chartRevenue.Titles.Clear();
            var revenueByDay = bllBill.getRevenueByDate(month);
            foreach (var res in revenueByDay)
            {
                //MessageBox.Show(bill.Day.ToString());

                chartRevenue.Series["Revenue"].Points.AddXY(res.Day, res.Revenue);
            }
            chartRevenue.ChartAreas[0].AxisX.Title = "Ngày";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (vnđ)";
            chartRevenue.Titles.Add("Biểu đồ doanh thu theo tháng " + month.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = comboBox1.Text;
            loadPieChart(choose);
        }
        private void cbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            int month = int.Parse(cbMonth.Text);

            loadChart(month);
        }
        private void tcAdmin_Selected(object sender, TabControlEventArgs e)
        {
            loadDashboard();
        }
        #endregion

        #region load datagridview
        void loadSchedule()
        {
            dtgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bllSchedule.displayDTGVSchedule(scheduleList);
        }

        void loadBillInfo()
        {
            dtgvBillInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bllBillInfo.displayDtgvBillInfo(billInfoList);
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
            txtCategoryCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "Category", true, DataSourceUpdateMode.Never));
            txtBrandCar.DataBindings.Add(new Binding("Text", dtgvCar.DataSource, "Brand", true, DataSourceUpdateMode.Never));
        }

        void AddScheduleBinding()
        {
            txtCustomerOfSchedule.DataBindings.Add(new Binding("Text", dtgvSchedule.DataSource, "CustomerName", true, DataSourceUpdateMode.Never));
            txtCarOfSchedule.DataBindings.Add(new Binding("Text", dtgvSchedule.DataSource, "CarName", true, DataSourceUpdateMode.Never));
            tbPickupDate.DataBindings.Add(new Binding("Text", dtgvSchedule.DataSource, "PickUpDate", true, DataSourceUpdateMode.Never));
            tbDropoffDate.DataBindings.Add(new Binding("Text", dtgvSchedule.DataSource, "DropOffDate", true, DataSourceUpdateMode.Never));
            txtDestination.DataBindings.Add(new Binding("Text", dtgvSchedule.DataSource, "LocationName", true, DataSourceUpdateMode.Never));
            txtStateOfCar.DataBindings.Add(new Binding("Text", dtgvSchedule.DataSource, "Status", true, DataSourceUpdateMode.Never));
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

        void AddBillBinding()
        {
            txtIdBill.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtCustomerOfBill.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "CustomerName", true, DataSourceUpdateMode.Never));
            txtCarOfBill.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "CarName", true, DataSourceUpdateMode.Never));
            txtRentDate.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "CreatedDate", true, DataSourceUpdateMode.Never));
            numCost.DataBindings.Add(new Binding("Value", dtgvBillInfo.DataSource, "Cost", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Schedule 
        private void btnReadSchedule_Click(object sender, EventArgs e)
        {
            loadSchedule();
        }
        private void btnTraXe_Click(object sender, EventArgs e)
        {
            DAO_Car dcar = new DAO_Car();
            var id = dcar.getCarId(txtCarOfSchedule.Text);
            saveStatusCar(id, dcar);
            if (txtStateOfCar.Text == "Trống")
            {
                txtStateOfCar.Text = "Đã trả xe";
            }
            loadCarList();
        }

        #endregion

        #region Car
        private void btnImportCarList_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CarDTO car = new CarDTO();
            if ((double)numCarPrice.Value < 0)
            {
                MessageBox.Show("Giá xe cần phải lớn hơn 0");
                numCarPrice.Value = 1;
            }
            car.CarName = txtCarName.Text;
            car.Price = (double)numCarPrice.Value;
            car.Category = txtCategoryCar.Text;
            car.Brand = txtBrandCar.Text;

            bllCar.AddCar(txtCarFuel.Text, car);
            loadCarList();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            CarDTO car = new CarDTO();
            if ((double)numCarPrice.Value < 0)
            {
                MessageBox.Show("Giá xe cần phải lớn hơn 0");
                numCarPrice.Value = 1;
            }
            car.CarName = txtCarName.Text;
            car.Price = (double)numCarPrice.Value;
            car.Category = txtCategoryCar.Text;
            car.Brand = txtBrandCar.Text;
            bllCar.UpdateCar(int.Parse(txtCarId.Text), car, txtCarFuel.Text);
            loadCarList();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                bllCar.DeleteCar(int.Parse(txtCarId.Text));
                loadCarList();
            }
            return;
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            if (txtSearchCar.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm ");
                txtSearchCar.Focus();
                loadCarList();
                return;
            }
            var result = bllCar.SearchingCar(txtSearchCar.Text);
            if (result.Count != 0)
            {
                dtgvCar.DataSource = null;
                carList.Clear();
                carList.DataSource = result;
                dtgvCar.DataSource = carList;
            }
            else
            {
                MessageBox.Show("Người dùng không tồn tại!");
                txtSearchCustomer.Clear();
            }
        }
        #endregion

        #region Customer
        private void btnExportCustomer_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel Workbook (*.xlsx)|*.xlsx|Excel 97-2003 Workbook (*.xls)|*.xls|All Files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                exportToExcel(dtgvCustomer, saveFile.FileName);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm ");
                txtSearchCustomer.Focus();
                loadCustomerList();
                return;
            }
            var result = bllCustomer.searchCustomer(txtSearchCustomer.Text);
            if (result.Count != 0)
            {
                dtgvCustomer.DataSource = null;
                customerList.Clear();
                customerList.DataSource = result;
                dtgvCustomer.DataSource = customerList;
            }
            else
            {
                MessageBox.Show("Kết quả không tồn tại!");
                txtSearchCustomer.Clear();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "" && txtCCCD.Text == "")
            {
                MessageBox.Show("Cần điền ít nhất thông tin tên hoặc cccd để thêm mới khách hàng!");
                return;
            }
            if (txtPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng (10 số)");
                return;

            }
            if (txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("Số CCCD không đúng định dạng (12 số)");
                return;
            }
            CustomerDTO cusdto = new CustomerDTO();
            cusdto.CustomerName = txtNameCustomer.Text;
            cusdto.CustomerGender = txtGender.Text;
            cusdto.CustomerPhoneNum = txtPhoneNum.Text;
            cusdto.CustomerAddress = txtAddress.Text;
            cusdto.CustomerCCCD = txtCCCD.Text;
            bllCustomer.addCustomer(cusdto);
            loadCustomerList();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "" && txtCCCD.Text == "")
            {
                MessageBox.Show("Cần điền ít nhất thông tin tên hoặc cccd để thêm mới khách hàng!");
                return;
            }
            if (txtPhoneNum.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng (10 số)");
                return;

            }
            if (txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("Số CCCD không đúng định dạng (12 số)");
                return;
            }
            CustomerDTO cusdto = new CustomerDTO();
            cusdto.CustomerName = txtNameCustomer.Text;
            cusdto.CustomerGender = txtGender.Text;
            cusdto.CustomerPhoneNum = txtPhoneNum.Text;
            cusdto.CustomerAddress = txtAddress.Text;
            cusdto.CustomerCCCD = txtCCCD.Text;
            bllCustomer.updateCustomer(int.Parse(txtCustomerId.Text), cusdto);
            loadCustomerList();
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
        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchBill.Text))
            {
                MessageBox.Show("Cần nhập thông tin để tìm kiếm");
                loadBillInfo();
                return;
            }
            else
            {
                var result = bllBillInfo.searchingBill(txtSearchBill.Text);
                if (result.Count != 0)
                {
                    dtgvBillInfo.DataSource = null;
                    billInfoList.Clear();
                    billInfoList.DataSource = result;
                    dtgvBillInfo.DataSource = billInfoList;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin cần tìm kiếm");
                    loadBillInfo();
                    return;
                }
            }
        }

        private void btnReadBill_Click(object sender, EventArgs e)
        {
            loadBillInfo();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Method
        private void exportToExcel(DataGridView dtgv, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Workbook workbook;
            Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Danh sách khách hàng";

                // export header
                for (int i = 0; i < dtgv.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dtgv.Columns[i].HeaderText;
                }

                // export content
                for (int i = 0; i < dtgv.RowCount; i++)
                {
                    for (int j = 0; j < dtgv.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgv.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save workbook
                workbook.SaveAs(filePath);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Export successful.!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void changeStatusBill(int id)
        {
            DAO_Bill dBill = new DAO_Bill();
            dBill.saveStatusById(id);
        }

        private void saveStatusCar(int id, DAO_Car dcar)
        {
            dcar.StatusChange(id, "trống");
        }

        #endregion



        
    }
}
