using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class DAO_BillInfo
    {
        MainDbContext _context;
        public DAO_BillInfo() {
            _context = new MainDbContext();
        }

        public dynamic getBillInfos()
        {
            var res = _context.BillInfos!.Select(e => new {e.Id,e.BillId, e.Customer.CustomerName, e.Car.CarName, e.Bill.Cost, e.Bill.CreatedDate, e.Bill.Status}).ToList();
            return res;
        }

        public void addBillInfos(BillInfoDTO billinfodto)
        {
            var info = new BillInfo();
            info.BillId = billinfodto.BillId;
            info.CustomerId = billinfodto.CustomerId;
            info.CarId = billinfodto.CarId;
            info.LocationId = billinfodto.DestinationId;
            info.ScheduleId = billinfodto.ScheduleId;
            _context.BillInfos.Add(info);
            _context.SaveChanges();
        }

        public dynamic searchingBill(string key)
        {
            var res = _context.BillInfos.Where(e => e.Car.CarName.Contains(key) || e.Customer.CustomerName.Contains(key)).Select(e => new { e.Id, e.BillId, e.Customer.CustomerName, e.Car.CarName, e.Bill.Cost, e.Bill.CreatedDate, e.Bill.Status }).ToList();
            return res;
        }

        public List<RevenueCarDTO> getRevenueByCar(string key)
        {
            dynamic? _car = null;
            switch(key) 
            {
                case "Tên":
                    _car = GetBillInfos().GroupBy(e => e.Car.CarName)
                                    .Select(r => new
                                    {
                                        carBrand = r.Key,
                                        totalRevenue = r.Sum(e => e.Bill.Cost)
                                    });
                    break;
                case "Loại":
                    _car = GetBillInfos().GroupBy(e => e.Car.Category)
                                    .Select(r => new
                                    {
                                        carBrand = r.Key,
                                        totalRevenue = r.Sum(e => e.Bill.Cost)
                                    });
                    break;
                case "Hãng":
                    _car = GetBillInfos().GroupBy(e => e.Car.Brand)
                                    .Select(r => new
                                    {
                                        carBrand = r.Key,
                                        totalRevenue = r.Sum(e => e.Bill.Cost)
                                    });
                    break;
            }
            List<RevenueCarDTO> res = new List<RevenueCarDTO>();
            foreach(var item in _car)
            {
                RevenueCarDTO revenueCarDTO = new RevenueCarDTO();
                revenueCarDTO.carName = item.carBrand;
                revenueCarDTO.carRevenue = item.totalRevenue;
                res.Add(revenueCarDTO);
            }
            return res;
                    
        }

        public List<BillInfo> GetBillInfos()
        {
            return _context.BillInfos.Include(e => e.Bill)
                                     .Include(e => e.Car)
                                     .ToList();
        }
    }
}
