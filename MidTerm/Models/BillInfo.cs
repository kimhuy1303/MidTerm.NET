using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BillInfo
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public Bill? Bill {  get; set; } 

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        
        public int CarId { get; set; }
        public Car? Car { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; } = null!;

        [Column("DestinationId")]
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;
    }
}
