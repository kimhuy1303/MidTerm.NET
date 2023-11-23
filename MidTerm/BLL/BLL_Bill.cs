using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BLL_Bill
    {
        DAO_Bill dBill;
        public BLL_Bill() 
        {
            dBill = new DAO_Bill();
        }

        public double getTotalRenevue()
        {
            return dBill.TotalRevenue();
        }

        public int getTotalBills()
        {
            return dBill.TotalBills();
        }

        public List<RevenueDTO> getRevenueByDate(int month)
        {
            return dBill.getRevenueByDate(month);
        }

        public List<Bill> GetBills()
        {
            return dBill.getBills();
        }
    }
}
