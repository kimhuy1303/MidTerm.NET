using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Fuel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? FuelName { get; set; }
        public ICollection<Car> Cars { get; } = new List<Car>();
    }
}
