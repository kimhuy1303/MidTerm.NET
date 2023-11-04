using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm   
{
    public class BLL_Schedule
    {
        DAO_Schedule dao_Schedule;
        public BLL_Schedule()
        {
            dao_Schedule = new DAO_Schedule();
        }

        public void displayDTGVSchedule(BindingSource bdsrc)
        {
            bdsrc.DataSource = dao_Schedule.getSchedule();
        }
    }
}
