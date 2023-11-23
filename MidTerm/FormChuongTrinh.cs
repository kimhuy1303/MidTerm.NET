
using MidTerm.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MidTerm
{
    public partial class FormChuongTrinh : Form
    {

        BLL_Car bllCar;
        BLL_Feature bllFeature;
        BLL_Location bllLocation;
        BLL_Customer bllCustomer;
        public bool isClose = true;
        public Font font = new Font("Arial", 9, FontStyle.Regular);
        public FormChuongTrinh()
        {
            InitializeComponent();
            bllCar = new BLL_Car();
            bllFeature = new BLL_Feature();
            bllLocation = new BLL_Location();
            bllCustomer = new BLL_Customer();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            bllCar.DisplayCarList(new Button(), pnCar);
            bllFeature.displayFeatureList(new CheckBox(), pnFeature);
            bllLocation.DisplayLocation(cbLocation);

        }
        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }
        public event EventHandler Logout;
        private void LogoutTool_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset(sender, e);
        }

        private void managementTool_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.ShowDialog();
            f.CloseForm += F_CloseForm;
            this.reset(sender, e);
        }

        private void F_CloseForm(object? sender, EventArgs e)
        {
            (sender as FormAdmin).isClose = false;
            (sender as FormAdmin).Close();
        }

        private void btnDatXe_Click(object sender, EventArgs e)
        {
            DAO_Customer dCustomer = new DAO_Customer();
            DAO_Car dCar = new DAO_Car();
            DAO_Bill dBill = new DAO_Bill();
            var customer = new Customer();
            var carId = Const.CarId;
            var destinationId = Const.DestinationId;
            var features = Const.Features;
            DateTime pickupdate = Convert.ToDateTime(dtpPickUp.Value);
            DateTime dropoffdate = Convert.ToDateTime(dtpDropOff.Value);
            double deposit = Decimal.ToDouble(numDeposit.Value);
            TimeSpan span = dropoffdate.Subtract(pickupdate);
            double daysTotal = span.TotalDays;
            if (checkValidField(carId, destinationId, daysTotal, pickupdate))
            {
                var car = dCar.getCarById(carId);

                if (dCustomer.checkIsExists(txtCCCD.Text))
                {
                    customer = bllCustomer.searchCustomer(txtCCCD.Text).First();
                }
                else
                {
                    addCustomer(dCustomer);
                    customer = bllCustomer.searchCustomer(txtCCCD.Text).First();
                }
                FormBillInfo f = new FormBillInfo(customer, car, pickupdate, dropoffdate, features, deposit, car.Price * daysTotal, destinationId, daysTotal);
                f.ShowDialog();
                f.CloseForm += F_CloseForm1;
                //saveStatusCar(carId, dCar);
                //addBill(car, daysTotal, dBill);
                //addSchedule(pickupdate, dropoffdate, bllSchedule);
                //var scheduleId = bllSchedule.getScheduleId();
                //var billId = dBill.getIdBillLastest();
                //addBillinfo(carId, destinationId, customer, scheduleId, billId, bllBillInfo);
                //MessageBox.Show("Thuê xe thành công!");
                //reset(sender, e);
            }
        }

        #region Close BillInfoForm
        private void F_CloseForm1(object? sender, EventArgs e)
        {
            (sender as FormBillInfo).isClose = false;
            (sender as FormBillInfo).Close();
        }
        #endregion


        public void reset(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.FormChuongTrinh_Load(sender, e);
        }

        private void addCustomer(DAO_Customer dCustomer)
        {
            if (!dCustomer.checkIsExists(txtCCCD.Text))
            {
                CustomerDTO cusdto = new CustomerDTO();
                cusdto.CustomerCCCD = txtCCCD.Text;
                cusdto.CustomerAddress = txtAddress.Text;
                cusdto.CustomerName = txtName.Text;
                cusdto.CustomerGender = cbGender.Text;
                cusdto.CustomerPhoneNum = txtPhoneNum.Text;
                bllCustomer.addCustomer(cusdto);
            }
        }
        private bool checkValidField(int carId, int destinationId, double daysTotal, DateTime pickupdate)
        {
            string error = "";
            bool isError = false;
            if (pickupdate < DateTime.UtcNow)
            {
                error += "- Ngày thuê xe không hợp lệ";
                isError = true;
            }
            if (daysTotal < 0)
            {
                error += "- Thời gian thuê không đúng \n";
                isError = true;
            }
            if (destinationId == 0)
            {
                error += "- Vui lòng chọn địa điểm \n";
                isError = true;
            }
            if (carId == 0)
            {
                error += "- Vui lòng chọn xe để thuê \n";
                isError = true;
            }
            if (txtName.Text == "" && txtCCCD.Text == "")
            {
                error += "- Cần điền ít nhất thông tin tên hoặc cccd để thêm mới khách hàng \n";
                isError = true;
            }
            if (txtPhoneNum.Text.Length != 10)
            {
                error += "- Số điện thoại không đúng định dạng (10 số) \n";
                isError = true;
            }
            if (txtCCCD.Text.Length != 12)
            {
                error += "- Số CCCD không đúng định dạng (12 số) \n";
                isError = true;
            }
            if (isError)
            {
                MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                MessageBox.Show("Cần nhập thông tin để tìm kiếm");
                return;
            }
            List<Customer> result = bllCustomer.searchCustomer(txtSearchCustomer.Text);
            if (result.Count != 0)
            {
                txtName.Text = result[0].CustomerName;
                cbGender.Text = result[0].Gender;
                txtCCCD.Text = result[0].CCCD;
                txtPhoneNum.Text = result[0].PhoneNumber;
                txtAddress.Text = result[0].Address;
                txtSearchCustomer.Clear();
            }
            else
            {
                MessageBox.Show("Người dùng không tồn tại!");
                txtSearchCustomer.Clear();
                return;
            }
        }

        private void cbLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Const.DestinationId = int.Parse(cbLocation.GetItemText(cbLocation.SelectedValue));

        }


    }
}