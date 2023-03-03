using Business.Concrete;
using DataAccess.Concrete.Entityframework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            carManager.Add(new Car
            {
                Id = 3,
                BrandId = 2,
                ColorId = 4,
                DailyPrice = 331,
                Description = "Konforlu şık sedan",
                ModelYear = 2021

            });






        }
    }
}