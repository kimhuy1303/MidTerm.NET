using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class DAO_Customer
    {
        MainDbContext _context;
        public DAO_Customer() 
        {
            _context = new MainDbContext();
        }

        public dynamic getCustomer()
        {
            var customers = _context.Customers!.Select(e => new {e.Id, e.CustomerName, e.Gender, e.CCCD, e.PhoneNumber,e.Address}).ToList();
            return customers;
        }

       public bool checkIsExists(string cccd)
        {
            var checkCCCD = _context.Customers.Find(cccd);

            return checkCCCD != null ? true : false;
        }

        public void addCustomer(string name, string cccd, string phoneNum, string gender,string address) 
        {
            
            
                var customer = new Customer
                {
                    CustomerName = name,
                    CCCD = cccd,
                    PhoneNumber = phoneNum,
                    Gender = gender,
                    Address = address
                };
                _context.Add(customer);
                _context.SaveChanges();
            
        }

        public Customer searchCustomerByName(string name)
        {
            var res = _context.Customers.Where(c => c.CustomerName == name).FirstOrDefault();
            return res;
        }
    }
}
