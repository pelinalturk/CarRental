using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=new DateTime(1991), DailyPrice=300, Description = "Audi"},
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear=new DateTime(1990), DailyPrice=300, Description = "Mercedes"},
                new Car{Id=3, BrandId=3, ColorId=3, ModelYear=new DateTime(2021), DailyPrice=1000, Description = "BMW"},
                new Car{Id=4, BrandId=4, ColorId=4, ModelYear=new DateTime(2010), DailyPrice=400, Description = "Range Rover"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car removeCar = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(removeCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car updateCar = _car.SingleOrDefault(c => c.Id == car.Id);
            updateCar.BrandId = 5;
            updateCar.ColorId = 5;
            updateCar.DailyPrice = 500;
            updateCar.Description = "Renault";
            updateCar.ModelYear = new DateTime(2018);
        }
    }
}
