using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? LocationName { get; set; }

        public ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();
    }
}
