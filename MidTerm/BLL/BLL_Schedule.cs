using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm   
{
    public class BLL_Schedule
    {
        DAO_Schedule dSchedule;
        public BLL_Schedule()
        {
            dSchedule = new DAO_Schedule();
        }

        public void displayDTGVSchedule(BindingSource bdsrc)
        {
            bdsrc.DataSource = dSchedule.getScheduleList();
        }

        public void addSchedule(ScheduleDTO scheduledto)
        {
            dSchedule.addSchedule(scheduledto);
        }

        public int getScheduleId()
        {
            var res = dSchedule.getSchedule();
            return res.Id;
        }

        public dynamic searchSchedule(string key)
        {
            return dSchedule.seachSchedule(key);
        }
    }
}
