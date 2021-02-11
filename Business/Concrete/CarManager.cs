using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);

            }
            else
            {
                
                return new ErrorResult(Messages.BrandNameInvalid);
            }

        }

        public IDataResult<List<Car>>GetAll()
        {
            if (DateTime.Now.Hour == 24)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);



             }
                return new SuccessDataResult<List<Car>> (_carDal.GetAll());

        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public object GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByBrandId(string id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandName == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(string id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorName == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}