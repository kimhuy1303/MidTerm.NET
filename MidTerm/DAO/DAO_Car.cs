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

        #region Get List Id,Name,IsAvailable of Car
        public dynamic GetNameOfCar()
        {
            var cars = _context.Cars!.Select(e => new { e.Id, e.CarName, e.Status});
            return cars;
        }
        #endregion

        public dynamic GetCars()
        {
            var cars = _context.Cars!.Select(e => new {e.Id, e.CarName, e.Price, e.Fuel!.FuelName, e.Status}).ToList();
            return cars;
        }


        #region Add Car Item
        public void AddCar(string fuelName,CarDTO carDTO)
        {
            var fuelId = _context.Fuels!.Where(e => e.FuelName == fuelName).FirstOrDefault();
            var car = new Car
            {
                CarName = carDTO.CarName,
                Description = carDTO.Description,
                Price = carDTO.Price,
                FuelId = fuelId!.Id
            };
            _context.Cars!.Add(car);
            _context.SaveChanges();
        }
        #endregion

        public void UpdateCar(int id, CarDTO carDTO) 
        {
        }
        public void DeleteCar(int id) 
        {
            var car = _context.Cars!.FirstOrDefault(e => e.Id == id);
            _context.Cars!.Remove(car!);
            _context.SaveChanges();
        }
    }
}
