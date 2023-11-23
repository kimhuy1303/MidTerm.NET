using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BillInfoDTO
    {
        public int BillId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public int DestinationId { get; set; }
        public int ScheduleId { get; set; }

    }
}
