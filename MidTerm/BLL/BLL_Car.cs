using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MidTerm
{
    public class BLL_Car
    {
        Button currentBtn;
        DAO_Car dCar;
        public BLL_Car() 
        {
            dCar = new DAO_Car();
        }
        List<string> listBtnRents = new List<string>();
        public void DisplayCarList(Button button, FlowLayoutPanel flpn)
        {
            var width = 110;
            var height = 90;
           var cars = dCar.GetCars();
            foreach (var car in cars) 
            {
                button = new Button();
                button.BackColor = Color.WhiteSmoke;
                button.Width = width;
                button.Height = height;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Text = car.CarName + Environment.NewLine + "(" + car.Category + ", " + car.Brand + ")" + Environment.NewLine + car.Status;
                button.Font = new FormChuongTrinh().font;
                button.Tag = car.Id;
                button.Name = car.Id.ToString();
                switch (car.Status)
                {
                    case "Trống":
                        button.BackColor = Color.WhiteSmoke; 
                        break;
                    default:
                        listBtnRents.Add(button.Name);
                        button.BackColor = Color.Pink;
                        button.Enabled = false;
                        break;
                }
                button.Click += new EventHandler((sender, e) => Button_Click(sender, e, flpn));
                flpn.Controls.Add(button);
            }
        }

        private void DisableButton(FlowLayoutPanel flpn)
        {
            foreach (Control previousBtn in flpn.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    if (!listBtnRents.Contains(previousBtn.Name))
                    {
                        previousBtn.BackColor = Color.WhiteSmoke;
                        previousBtn.ForeColor = Color.Black;
                    }
                }
            }
        }
        private void ActiveButton(object btnSender, FlowLayoutPanel flpn)
        {
            if (btnSender != null)
            {
                Button btn = (Button)btnSender;
                if (!listBtnRents.Contains(btn.Name))
                {
                    if (currentBtn != btn)
                    {
                        DisableButton(flpn);
                    }
                    currentBtn = btn;
                    currentBtn.BackColor = Color.YellowGreen;
                    currentBtn.ForeColor = Color.White;
                }
            }
        }

        private void Button_Click(object? sender, EventArgs e, FlowLayoutPanel flpn)
        {
            ActiveButton((sender as Button), flpn);
            var res = (sender as Button).Tag;
            Const.CarId = int.Parse(res.ToString());
        }


        public void LoadDtgvListOfCar(BindingSource bdsrc)
        {
            bdsrc.DataSource = dCar.GetCars();
        }
        public void AddCar(string fuelName,CarDTO cardto)
        {
            if (!dCar.checkCarExists(cardto.CarName, cardto.Category,cardto.Brand))
            {
                dCar.AddCar(fuelName, cardto);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Xe đã tồn tại hoặc các thuộc tính khác của xe không hợp lệ");
            }
        }

        public void UpdateCar(int id,CarDTO carDTO, string fuelName)
        {
            try
            {
                dCar.UpdateCar(id,carDTO, fuelName);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        public void DeleteCar(int id)
        {
            try
            {
                dCar.DeleteCar(id);
                MessageBox.Show("Xóa thành công ");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        public dynamic SearchingCar(string key)
        {
            return dCar.SearchCar(key);
        }
    
        public int CarsTotal()
        {
            return dCar.CarsTotal();
        }
    }
}
