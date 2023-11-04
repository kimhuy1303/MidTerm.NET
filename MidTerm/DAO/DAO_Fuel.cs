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

        public List<string> getFuelList()
        {
            var fuels = _context.Fuels!.Select(e => e.FuelName).ToList();
            return fuels!;
        }
    }
}
