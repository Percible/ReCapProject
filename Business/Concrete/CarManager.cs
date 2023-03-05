using Business.Abstract;
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
        public void Add(Car car)
        {
            if (car.Description.Length <= 2 || car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba ismi 2 karakterden küçük olamaz veya günlük ücreti 0 dan küçük olamaz");
            }
            else
            {
                _carDal.Add(car);
            }
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }
        public List<CarDetails> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }
        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(p => p.ColorId == colorid);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
