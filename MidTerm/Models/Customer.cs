using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Customer
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? CustomerName{ get; set; }
        [MaxLength(100)]

        public string? Gender { get; set; }
        
        public string? CCCD {  get; set; }
        public string? PhoneNumber { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; }

        public ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>(); 

    }
}
