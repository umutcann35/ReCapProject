using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private Car carToDelete;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            { 
                new Car{CarId=1,BrandId="Mercedes",ColorId="Black",DailyPrice=650,ModelYear=2021,Description="2021 MODEL MERCEDES C180 BENZİNLİ"},
                new Car{CarId=2,BrandId="BMW",ColorId="Blue",DailyPrice=580,ModelYear=2020,Description="2020 MODEL BMW 320d DİZEL"},
                new Car{CarId=3,BrandId="Toyota",ColorId="Grey",DailyPrice=450,ModelYear=2019,Description="2019 MODEL TOYOTA COROLLA  BENZİNLİ"},
                new Car{CarId=4,BrandId="Audi",ColorId="Black",DailyPrice=500,ModelYear=2018,Description="2018 MODEL AUDİ A3 BENZİNLİ"},
                new Car{CarId=5,BrandId="Renault",ColorId="White",DailyPrice=350,ModelYear=2020,Description="2020 MODEL RENAULT CLİO HATCHBACK DİZEL"}
            
            
            
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

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
