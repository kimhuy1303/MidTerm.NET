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
            var checkCCCD = _context.Customers.Where(r => r.CCCD == cccd).FirstOrDefault();

            return checkCCCD != null ? true : false;
        }

        public void addCustomer(CustomerDTO customerdto) 
        {
                var customer = new Customer
                {
                    CustomerName = customerdto.CustomerName,
                    CCCD = customerdto.CustomerCCCD,
                    PhoneNumber = customerdto.CustomerPhoneNum,
                    Gender = customerdto.CustomerGender,
                    Address = customerdto.CustomerAddress
                };
                _context.Add(customer);
                _context.SaveChanges();
            
        }

        public List<Customer> searchCustomer(string key)
        {
            var res = _context.Customers.Where(c => c.CustomerName.Contains(key) || c.CCCD.Contains(key) || c.PhoneNumber.Contains(key)).ToList();
            return res;
        }

        public void UpdateCustomer(int id, CustomerDTO customerdto)
        {
            var customer = _context.Customers.FirstOrDefault(e => e.Id == id);
            if(customer != null)
            {
                customer.CustomerName = customerdto.CustomerName;
                customer.Gender = customerdto.CustomerGender;
                customer.Address = customerdto.CustomerAddress;
                customer.PhoneNumber = customerdto.CustomerPhoneNum;
                customer.CCCD = customerdto.CustomerCCCD;
                _context.SaveChanges();
                MessageBox.Show("Sửa thành công");
            }
        }

        public void deleteCustomer(int id)
        {
            var res = _context.Customers.Find(id);
            _context.Remove(res);
            _context.SaveChanges();
        }

        public int CustomersTotal()
        {
            var amount = _context.Customers.Count();
            return amount;
        }
    }
}
