using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm { 
    public class DAO_Fuel
    {
        MainDbContext _context;
        public DAO_Fuel()
        {
            _context = new MainDbContext(); 
        }
        public string GetFuelName(int id)
        {
            var res = _context.Fuels.FirstOrDefault(f => f.Id == id);
            return res.FuelName;
        }
    }
}
