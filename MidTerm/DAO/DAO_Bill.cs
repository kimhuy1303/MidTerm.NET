using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class DAO_Bill
    {
        MainDbContext _context;
        public DAO_Bill() 
        {
            _context = new MainDbContext();
        }

        public void addBill(BillDTO billdto)
        {
            var bill = new Bill();
            bill.CreatedDate = billdto.CreatedDate;
            bill.Deposit = billdto.Deposit;
            bill.Cost = billdto.Cost;
            bill.Status = billdto.Status;
            bill.BillInfo = billdto.BillInfo;
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }

        public int getIdBillLastest()
        {
            var res = _context.Bills.OrderByDescending(e => e.CreatedDate).FirstOrDefault();
            return res.Id;
        }

        public void saveStatusById(int id)
        {
            var bill = _context.Bills.FirstOrDefault(e => e.Id == id);
            bill.Status = 1;
            _context.SaveChanges();
        }

        public double TotalRevenue()
        {
            var revenue = _context.Bills.Sum(e => e.Cost);
            return revenue;
        }

        public int TotalBills()
        {
            var amount = _context.Bills.Count();
            return amount;
        }

        public List<RevenueDTO> getRevenueByDate(int month)
        {
            //var dayDistinct = getBills().Where(e => e.CreatedDate.Month == month).Select(e => new { e.CreatedDate.Day}).Distinct();
            var dayDistinct = getBills().Where(e => e.CreatedDate.Month == month)
                                        .GroupBy(e => e.CreatedDate.Day)
                                        .Select(group => new
                                        {
                                            day = group.Key,
                                            TotalRevenue = group.Sum(group => group.Cost)
                                        }).OrderBy(e => e.day);
            var res = new List<RevenueDTO>();
            foreach (var result in dayDistinct) 
            {
                var revenuedto = new RevenueDTO();
                //var revenue = _context.Bills.GroupBy(e => e.CreatedDate.Day).Sum(e => e.Cost);
                revenuedto.Day = result.day;
                revenuedto.Revenue = result.TotalRevenue;
                res.Add(revenuedto);
            }
             return res;
        }

        public List<Bill> getBills()
        {
            return _context.Bills.ToList();
        }
    }
}
