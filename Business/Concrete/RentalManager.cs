using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            // clean code olarak tekrar oluşturdum
            var existingRental = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (existingRental != null)
            {
                return new ErrorResult("Araba dolu");
            }

            _rentalDal.Add(rental);
            return new SuccessResult("Arabayı Kiraladınız");





            //var result = _rentalDal.Get(filter: c => c.CarId == rental.CarId && c.ReturnDate == null);
            //Rental? CarControl = _rentalDal.Get(filter: c => c.CarId == rental.CarId);
            //if (result != null && result.ReturnDate == null && CarControl != null)
            //{
            //    return new ErrorResult("Araba dolu");
            //}

            //return new SuccessResult("Arabayı Kiraladınız");
            //var result = _rentalDal.GetAll();
            //IResult res = null;


            //foreach (var item in result)
            //{
            //    if (item.ReturnDate == null && item.CarId != null)
            //    {
            //        res = new ErrorResult("Araba dolu");

            //    }
            //    else
            //    {
            //        res = new SuccessResult("araba müsait");
            //        break;
            //    }


            //}
            //return res;

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Başarılı");
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Başarılı");
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.Id == id), "başarılı");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "başarılı");
        }
    }
}
