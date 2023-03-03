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
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>()
            {
                new Car(){Id=1,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=480,Description="Konforlu ve şık tasarıma sahip, günlük kullanıma uygun araba."},
                new Car(){Id=2,BrandId=2,ColorId=2,ModelYear=2014,DailyPrice=320,Description="Kompakt bir araç olan bu model, şehir içi kullanıma son derece uygun."},
                new Car(){Id=3,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=200,Description="Geniş bagaj hacmi ve yakıt tasarruflu motoruyla ideal bir aile arabası."},
                new Car(){Id=4,BrandId=3,ColorId=3,ModelYear=2004,DailyPrice=150,Description="Güvenliği ön planda tutan, teknolojik özellikleriyle öne çıkan araç."},
                new Car(){Id=5,BrandId=3,ColorId=5,ModelYear=2007,DailyPrice=175,Description="Sportif tasarımı ve yüksek performansıyla dikkatleri üzerine çeken bir araba."}

            };

        }



        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;

            carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;


        }
    }
}
