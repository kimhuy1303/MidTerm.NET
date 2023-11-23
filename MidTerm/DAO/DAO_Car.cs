using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    public class DAO_Car
    {
        MainDbContext _context;
        public DAO_Car()
        {
            _context = new MainDbContext();
        }

        public dynamic GetCars()
        {
            var cars = _context.Cars!.Select(e => new {e.Id, e.CarName, e.Category, e.Brand, e.Price, e.Fuel.FuelName, e.Status}).ToList();
            return cars;
        }
        
        public int getCarId(string name)
        {
            var car = _context.Cars!.FirstOrDefault(e => e.CarName == name);
            return car.Id;
        }

        public Car getCarById(int id)
        {
            var car = _context.Cars.FirstOrDefault(e => e.Id == id);
            return car;
        }
        #region Add Car Item
        public void AddCar(string fuelName,CarDTO carDTO)
        {
            var fuelId = _context.Fuels!.Where(e => e.FuelName == fuelName).FirstOrDefault();
            if(fuelId != null)
            {
                var car = new Car
                {
                    CarName = carDTO.CarName,
                    Category = carDTO.Category,
                    Brand = carDTO.Brand,
                    Price = carDTO.Price,
                    FuelId = fuelId!.Id
                };
                _context.Cars!.Add(car);
                _context.SaveChanges();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Không tồn tại nhiên liệu này");
            }
        }
        #endregion

        public bool checkCarExists(string name, string cate, string brand)
        {
            var check = _context.Cars.FirstOrDefault(e => e.CarName == name && e.Category == cate && e.Brand == brand);
            return check == null ? false : true;
        }

        public void UpdateCar(int id, CarDTO carDTO, string fuelName)
        {
            var fuelId = _context.Fuels.Where(e => e.FuelName == fuelName).FirstOrDefault();
            var car = _context.Cars.Find(id);
            if (car != null && fuelId != null)
            {
                car.CarName = carDTO.CarName;
                car.Category = carDTO.Category;
                car.Brand = carDTO.Brand;
                car.Price = carDTO.Price;
                car.FuelId = fuelId.Id;
                _context.SaveChanges();
                MessageBox.Show("Sửa thành công");
            }
            if(fuelId == null)
            {
                MessageBox.Show("Không tồn tại nhiên liệu này");
            }
        }

        public void StatusChange(int id, string text)
        {
            var car = _context.Cars.Find(id);
            car.Status = Const.ToTitleCase(text);
            _context.SaveChanges();
        }
        public void DeleteCar(int id) 
        {
            var car = _context.Cars!.FirstOrDefault(e => e.Id == id);
            _context.Cars!.Remove(car!);
            _context.SaveChanges();
        }
    
        public dynamic SearchCar(string key)
        {
            var fuelId = _context.Fuels.Where(e => e.FuelName.Contains(key)).FirstOrDefault();
            if(fuelId == null)
            {
               var result = _context.Cars.Where(e => e.CarName.Contains(key) || e.Category.Contains(key) || e.Brand.Contains(key)).Select( e=> new { e.Id, e.CarName, e.Category, e.Brand, e.Price, e.Fuel.FuelName, e.Status }).ToList();
               return result;
            }
            else
            {
                var result = _context.Cars.Where(e => e.FuelId.Equals(fuelId.Id)).Select(e => new { e.Id, e.CarName, e.Category, e.Brand, e.Price, e.Fuel.FuelName, e.Status }).ToList();
                return result;
            }
            
        }

        public int CarsTotal()
        {
            var amount = _context.Cars.Count();
            return amount;
        }
    }
}
