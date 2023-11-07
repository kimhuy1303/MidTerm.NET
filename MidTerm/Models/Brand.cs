using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [MaxLength(100)]
        public int BrandName { get; set; }
        public ICollection<Car> Cars { get; } = new List<Car>();

    }
}
