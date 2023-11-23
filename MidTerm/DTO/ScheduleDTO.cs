using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class ScheduleDTO
    {
        public DateTime PickupDate { get; set; }
        public DateTime DropoffDate { get; set; }
        public ICollection<BillInfo> BillInfos { get; set; } 
    }
}
