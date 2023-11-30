using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class FormBillInfo : Form
    {
        private Customer customer;
        private Car car;
        private DateTime pickUpDate;
        private DateTime dropOffDate;
        private List<Feature> features;
        private double deposit;
        private double totalCost;
        private double daysTotal;
        public int destinationId;
        public bool isClose = true;
        public event EventHandler CloseForm;

        public FormBillInfo(Customer customer, Car car, DateTime pickUpDate, DateTime dropOffDate, List<Feature> features, double deposit, double totalCost, int destinationId, double daysTotal)
        {
            InitializeComponent();

            this.customer = customer;
            this.car = car;
            this.pickUpDate = pickUpDate;
            this.dropOffDate = dropOffDate;
            this.features = features;
            this.deposit = deposit;
            this.totalCost = totalCost;
            this.destinationId = destinationId;
            this.daysTotal = daysTotal;

        }

        private void BillInfoForm_Load(object sender, EventArgs e)
        {
            var destination = getDestination(destinationId);
            double totalPriceFeatures = 0;
            lblFeatures.Text = "";
            if (features.Count == 0)
            {

                lblFeatures.Text = "- Xe không có chức năng thêm";
            }
            else
            {
                totalPriceFeatures = getPriceFeatures(features);
                foreach (Feature feature in features)
                {
                    lblFeatures.Text += "- " + feature.FeatureName + " - " + feature.FeaturePrice + "đ\n";
                }
            }
            double total = totalCost + totalPriceFeatures;
            tbCustomerName.Text = this.customer.CustomerName;
            tbPhoneNum.Text = this.customer.PhoneNumber;
            tbCCCD.Text = this.customer.CCCD;
            tbAddress.Text = this.customer.Address;
            tbCarName.Text = this.car.CarName;
            tbCarBrand.Text = this.car.Brand;
            dtpPickUpDate.Value = this.pickUpDate;
            dtpDropOffDate.Value = this.dropOffDate;
            tbDeposit.Text = Math.Ceiling(deposit).ToString() + "đ";
            tbTotalCost.Text = Math.Ceiling(total).ToString() + "đ";
            tbCost.Text = Math.Ceiling(total - deposit).ToString() + "đ";
            tbDestination.Text = destination.ToString();
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DAO_Customer dCustomer = new DAO_Customer();
            DAO_Car dCar = new DAO_Car();
            DAO_Bill dBill = new DAO_Bill();
            BLL_Schedule bllSchedule = new BLL_Schedule();
            BLL_BillInfo bllBillInfo = new BLL_BillInfo();
            addBill(car, daysTotal, dBill);
            addSchedule(pickUpDate, dropOffDate, bllSchedule);
            var scheduleId = bllSchedule.getScheduleId();
            var billId = dBill.getIdBillLastest();
            addBillinfo(car.Id, destinationId, customer, scheduleId, billId, bllBillInfo);
            saveStatusCar(car.Id, dCar);
            MessageBox.Show("Thuê xe thành công!");
            this.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Method

        private double getPriceFeatures(List<Feature> features)
        {
            double priceFeatures = 0;
            foreach (var feature in features)
            {
                priceFeatures += feature.FeaturePrice;
            }
            return priceFeatures;
        }
        private void addBill(Car car, double daysTotal, DAO_Bill dBill)
        {
            var billDTO = new BillDTO();
            billDTO.CreatedDate = DateTime.Now;
            billDTO.Deposit = Convert.ToDouble(tbDeposit.Text.Replace("đ", ""));
            billDTO.Cost = (car.Price * daysTotal);
            billDTO.Status = 0;
            dBill.addBill(billDTO);
        }
        private string getDestination(int destinationId)
        {
            DAO_Location dLoca = new DAO_Location();
            var res = dLoca.getLocationName(destinationId);
            return res.LocationName;
        }
        private void saveStatusCar(int id, DAO_Car dcar)
        {
            dcar.StatusChange(id, "Đang được thuê");
        }
        private void addBillinfo(int carId, int destinationId, Customer customer, int scheduleId, int billId, BLL_BillInfo bll)
        {
            var billinfo = new BillInfoDTO();
            billinfo.CarId = carId;
            billinfo.DestinationId = destinationId;
            billinfo.CustomerId = customer.Id;
            billinfo.ScheduleId = scheduleId;
            billinfo.BillId = billId;
            bll.addBillInfo(billinfo);
        }
        private void addSchedule(DateTime pickupdate, DateTime dropoffdate, BLL_Schedule bllSchedule)
        {
            var schedule = new ScheduleDTO();
            schedule.PickupDate = pickupdate;
            schedule.DropoffDate = dropoffdate;
            bllSchedule.addSchedule(schedule);
        }
        #endregion

        private void FormBillInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormChuongTrinh f = new FormChuongTrinh(Const.Authorize);
            f.reset(sender, e);
        }
    }
}
