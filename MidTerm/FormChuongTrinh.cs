
using MidTerm.BLL;

namespace MidTerm
{
    public partial class FormChuongTrinh : Form
    {

        BLL_Car bllCar;
        BLL_Feature bllFeature;
        BLL_Fuel bllFuel;
        BLL_Location bllLocation;
        BLL_Customer bllCustomer;
        public bool isClose = true;
        public Font font = new Font("Arial", 9, FontStyle.Regular);
        public FormChuongTrinh()
        {
            InitializeComponent();
            bllCar = new BLL_Car();
            bllFeature = new BLL_Feature();
            bllFuel = new BLL_Fuel();
            bllLocation = new BLL_Location();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            bllCar.DisplayCarList(new Button(), pnCar);
            bllFeature.displayFeatureList(new CheckBox(), pnFeature);
            bllFuel.displayFuelRadioBtn(new RadioButton(), pnFuel);
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
            this.Controls.Clear();
            this.InitializeComponent();
            this.FormChuongTrinh_Load(sender, e);

        }

        private void managementTool_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.Show();
            f.CloseForm += F_CloseForm;
        }

        private void F_CloseForm(object? sender, EventArgs e)
        {
            (sender as FormAdmin).isClose = false;
            (sender as FormAdmin).Close();
        }

        private void btnDatXe_Click(object sender, EventArgs e)
        {
            DAO_Customer dCustomer = new DAO_Customer();
            if (!dCustomer.checkIsExists(txtCCCD.Text))
            {
                bllCustomer.addCustomer(txtName.Text, txtCCCD.Text, txtPhoneNum.Text, cbGender.Text, txtAddress.Text);
            }
        }
    }
}