using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class DAO_Feature
    {
        MainDbContext _context;
        public DAO_Feature() 
        {
            _context = new MainDbContext();
        }

        public dynamic GetFeatureList()
        {
            var features = _context.Features!.Select(e => new { e.FeatureName });
            return features;
        }
    }
}
