using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? FeatureName { get; set; }
        public double FeaturePrice { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
