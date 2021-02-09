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
        List<Car> _cars;

        public int CarId { get; private set; }

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandName="Mercedes",ColorName="Black",DailyPrice=650,ModelYear=2021,Description="2021 MODEL MERCEDES C180 BENZİNLİ"},
                new Car{CarId=2,BrandName="BMW",ColorName="Blue",DailyPrice=580,ModelYear=2020,Description="2020 MODEL BMW 320d DİZEL"},
                new Car{CarId=3,BrandName="Toyota",ColorName="Grey",DailyPrice=450,ModelYear=2019,Description="2019 MODEL TOYOTA COROLLA  BENZİNLİ"},
                new Car{CarId=4,BrandName="Audi",ColorName="Black",DailyPrice=500,ModelYear=2018,Description="2018 MODEL AUDİ A3 BENZİNLİ"},
                new Car{CarId=5,BrandName="Renault",ColorName="White",DailyPrice=350,ModelYear=2020,Description="2020 MODEL RENAULT CLİO HATCHBACK DİZEL"}



            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.ColorName= car.ColorName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        public List<Car> GetAllByBrand(string BrandId)
        {
            return _cars.Where(c => c.BrandName == BrandId).ToList();
        }
        public List<Car> GetAllColor(string colorId)
        {
            return _cars.Where(c => c.ColorName == colorId).ToList();
        }

        
        
         
        

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}
        
