using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BLL_Fuel
    {
        DAO_Fuel dFuel;
        public BLL_Fuel()
        {
            dFuel = new DAO_Fuel();
        }

        public void displayFuelRadioBtn(RadioButton rbtn, Panel pn)
        {
            var fuels = dFuel.getFuelList();
            foreach (var fuel in fuels)
            {
                rbtn = new RadioButton();
                rbtn.Text = fuel;
                rbtn.Name = "rbtn" + fuels.IndexOf(fuel);
                rbtn.Font = new FormChuongTrinh().font;
                rbtn.CheckedChanged += Rbtn_CheckedChanged;
                pn.Controls.Add(rbtn);
            }
        }

        private void Rbtn_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;
            //MessageBox.Show(radioButton!.Text);
        }
    }
}
