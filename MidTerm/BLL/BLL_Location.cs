using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.BLL
{
    public class BLL_Location
    {
        DAO_Location dLocation;
        public BLL_Location()
        {
            dLocation = new DAO_Location();
        }

        public void DisplayLocation(ComboBox cb)
        {
            cb.DataSource = dLocation.GetLocation();
            cb.DisplayMember = "LocationName";
            cb.ValueMember = "Id";
        }
    }
}
