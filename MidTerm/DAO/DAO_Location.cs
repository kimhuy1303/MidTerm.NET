using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{ 
    public class DAO_Location
    {
        MainDbContext _context;
        public DAO_Location() 
        {
            _context = new MainDbContext();
        }

        public dynamic GetLocation()
        {
            var locations = _context.Locations?.OrderBy(e => e.Id).ToList();
            return locations!;
        }
    }
}
