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

        public void DisplayCarList(Button button, FlowLayoutPanel flpn)
        {
            var width = 100;
            var height = 75;
           var cars = dCar.GetNameOfCar();
            foreach (var car in cars) 
            {
                button = new Button();
                button.BackColor = Color.WhiteSmoke;
                button.Width = width;
                button.Height = height;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Text = car.CarName + Environment.NewLine + car.Status;
                button.Font = new FormChuongTrinh().font;
                switch (car.Status)
                {
                    case "Trống":
                        button.BackColor = Color.WhiteSmoke; 
                        break;
                    default:
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
                    previousBtn.BackColor = Color.WhiteSmoke;
                    previousBtn.ForeColor = Color.Black;
                }
            }
        }

        private void ActiveButton(object btnSender, FlowLayoutPanel flpn)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton(flpn);
                }
                currentBtn = (Button)btnSender;
                currentBtn.BackColor = Color.YellowGreen;
                currentBtn.ForeColor = Color.White;
            }
        }

        private void Button_Click(object? sender, EventArgs e, FlowLayoutPanel flpn)
        {
            Button? button = sender as Button;
            ActiveButton(button!, flpn);
        }

        public void LoadDtgvListOfCar(BindingSource bdsrc)
        {
            bdsrc.DataSource = dCar.GetCars();
        }
        public void AddCar(string fuelName,CarDTO cardto)
        {
            if (!dCar.checkCarExists(cardto.CarName, cardto.Description))
            {
                dCar.AddCar(fuelName, cardto);
            }
            else
            {
                MessageBox.Show("Xe đã tồn tại");
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

    }
}
