using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace MidTerm
{
    public class CarDTO
    {
        public string? CarName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Status { get; set; }
       // public ICollection<Feature> Features { get; } = new List<Feature>();
        public int FuelId { get; set; }
        public Fuel? Fuel { get; set; }
        //public ICollection<BillInfo> BillInfos { get; } = new List<BillInfo>();

        public CarDTO(string carName, double price, string status, int fuelId)
        {
            this.CarName = carName;
            this.Price = price;
            this.Status = status;
            this.FuelId = fuelId;
        }
        public CarDTO() { }
    }
}
