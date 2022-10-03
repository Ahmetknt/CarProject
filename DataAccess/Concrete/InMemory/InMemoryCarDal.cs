using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {  new Car { Id = 1, BrandId = 2, ColorId = 3, DailyPrice = 1500, Description = "BMW", ModelYear = 2010 },
                                    new Car { Id = 2, BrandId = 3, ColorId = 4, DailyPrice = 2000, Description = "Mercedes", ModelYear = 2012 },
                                    new Car { Id = 3, BrandId = 4, ColorId = 5, DailyPrice = 2500, Description = "Audi", ModelYear = 2015 },
                                    new Car { Id = 4, BrandId = 5, ColorId = 6, DailyPrice = 3000, Description = "Porsche", ModelYear = 2020 }};
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDeleted = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDeleted);
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

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.BrandId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdated = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdated.Id = car.Id;
            carToUpdated.BrandId = car.BrandId;
            carToUpdated.ColorId = car.ColorId;
            carToUpdated.DailyPrice = car.DailyPrice;
            carToUpdated.DailyPrice = car.DailyPrice;
            carToUpdated.ModelYear = car.ModelYear;
        }
    }
}
