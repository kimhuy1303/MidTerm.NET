using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BLL_Customer
    {
        DAO_Customer dCustomer;
        public BLL_Customer() 
        {
            dCustomer = new DAO_Customer();
        }

        public void DisplayCustomerDtgv(BindingSource bdsrc)
        {
            bdsrc.DataSource = dCustomer.getCustomer();
        }

        public void addCustomer(CustomerDTO cusdto)
        {
            try
            {
                if (!dCustomer.checkIsExists(cusdto.CustomerCCCD))
                {
                    dCustomer.addCustomer(cusdto);
                    MessageBox.Show("Thêm mới khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Thông tin cccd đã được sử dụng bởi khách hàng khác!");
                }
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        public List<Customer> searchCustomer(string key)
        {
            return dCustomer.searchCustomer(key);
        }
        
        public void updateCustomer(int id, CustomerDTO cusdto)
        {
            try
            {
                dCustomer.UpdateCustomer(id, cusdto);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public void deleteCustomer(int id)
        {
            try
            {
                dCustomer.deleteCustomer(id);
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
       
        public int GetCustomersTotal()
        {
            return dCustomer.CustomersTotal();
        }
    }
}
