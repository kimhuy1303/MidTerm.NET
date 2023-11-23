using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class BLL_BillInfo
    {
        DAO_BillInfo dBillInfo;
        public BLL_BillInfo() 
        {
            dBillInfo = new DAO_BillInfo();
        }

        public void displayDtgvBillInfo(BindingSource bdsrc)
        {
            bdsrc.DataSource = dBillInfo.getBillInfos();
        }

        public void addBillInfo(BillInfoDTO billinfodto)
        {
            try
            {
                dBillInfo.addBillInfos(billinfodto);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        public dynamic searchingBill(string key)
        {
            return dBillInfo.searchingBill(key);
        }

        public List<RevenueCarDTO> getRevenueByCar(string key)
        {
            return dBillInfo.getRevenueByCar(key);
        }
    }
}
