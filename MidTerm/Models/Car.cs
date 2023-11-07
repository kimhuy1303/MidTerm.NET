﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string? CarName { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }

        public double Price { get; set; }

        //[DefaultValue("Trống")]
        public string? Status { get; set; } = "Trống";

        public ICollection<Feature> Features { get; } = new List<Feature>();
        public int FuelId { get; set; }
        public Fuel? Fuel { get; set; }
        public ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();
        public ICollection<Brand> Brands { get; } = new List<Brand>();
    }
}
