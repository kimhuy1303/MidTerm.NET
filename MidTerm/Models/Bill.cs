﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; } // 0 - Chưa thanh toán ; 1 - Đã thanh toán
        public double Deposit {  get; set; }
        public double Cost { get; set; }
        public List<Feature> Features { get; set; }
        public BillInfo? BillInfo { get; set; }
    }
}
