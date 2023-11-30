using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public dynamic getScheduleList()
        {
            var schedules = _context.BillInfos!.Select(e => new { e.Customer!.CustomerName,e.Car!.Id, e.Car!.CarName, e.Schedule.PickUpDate, e.Schedule.DropOffDate, e.Location.LocationName, e.Car!.Status}).ToList();
            return schedules;
        }

        public dynamic getSchedule()
        {
            var res = _context.Schedules.OrderByDescending(e => e.Id).FirstOrDefault();
            return res;
        }

        public void addSchedule(ScheduleDTO scheduledto)
        {
            var schedule = new Schedule();
            schedule.PickUpDate = scheduledto.PickupDate;
            schedule.DropOffDate = scheduledto.DropoffDate;
            _context.Schedules.Add(schedule);
            _context.SaveChanges();
        }

        public dynamic seachSchedule(string key)
        {
            var res = _context.BillInfos.Where(e => e.Car.CarName.Contains(key) || e.Customer.CustomerName.Contains(key)).Select(e => new { e.Customer!.CustomerName, e.Car!.Id, e.Car!.CarName, e.Schedule.PickUpDate, e.Schedule.DropOffDate, e.Location.LocationName, e.Car!.Status }).ToList();
            return res;
        }
    }
}
