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

        public void addCustomer(string name, string cccd, string phoneNum, string gender, string address)
        {
            try
            {
                if (!dCustomer.checkIsExists(cccd))
                {
                    dCustomer.addCustomer(name, cccd, phoneNum, gender, address);
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

        public List<Customer> searchCustomerByName(string name)
        {
            return dCustomer.searchCustomerByName(name);
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
       
    }
}
