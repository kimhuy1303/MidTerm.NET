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

        public void GetFuelNameField(int id, TextBox txb)
        {
            var res = dFuel.GetFuelName(id);
            txb.Text = res;
        }

    }
}
