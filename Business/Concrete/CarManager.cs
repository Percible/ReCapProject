﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (car.Description.Length <= 2 || car.DailyPrice <= 0)
            {
                return new ErrorResult(Messages.CarNotAdded);
            }
            else
            {
                _carDal.Add(car);
                return new ErrorResult(Messages.CarAdded);
            }
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new ErrorResult(Messages.CarDeleted);
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }
        public IDataResult<List<CarDetails>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetails>>(_carDal.GetCarDetails());
        }
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorid)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorid));
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new ErrorResult(Messages.CarUpdated);
        }
    }
}
