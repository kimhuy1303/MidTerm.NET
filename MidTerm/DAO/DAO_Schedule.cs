using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class DAO_Schedule
    {
        MainDbContext _context;
        public DAO_Schedule()
        {
            _context = new MainDbContext();
        }

        public dynamic getSchedule()
        {
            var schedules = _context.BillInfos!.Select(e => new { e.Customer!.CustomerName, e.Car!.CarName, e.Schedule.PickUpDate, e.Schedule.DropOffDate, e.Location.LocationName, e.Car!.Status}).ToList();
            return schedules;
        }
    }
}
