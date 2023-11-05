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
            if (!dCustomer.checkIsExists(cccd))
            {
                dCustomer.addCustomer(name, cccd, phoneNum, gender, address);
            }
        }

        public Customer searchCustomerByName(string name)
        {
            return dCustomer.searchCustomerByName(name);
        }
       
    }
}
