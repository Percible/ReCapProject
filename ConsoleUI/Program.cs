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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //colorManager.Add(new Color { ColorName="Beyaz"});
            //colorManager.Update(new Color { Id=1,ColorName="Beyazzz"});
            //colorManager.Delete(new Color { Id = 1, ColorName = "Beyazzz" });
            //foreach (var item in colorManager.GetAll())
            //{
            //    Console.WriteLine(item.ColorName);
            //}
            //carManager.Update(new Car { Id=4,CarName="Tofaş",ColorId=5,DailyPrice=431,ModelYear=2031,Description="Konfor kalite",BrandId=5});
            //foreach (var c in carManager.GetAll())
            //{
            //    Console.WriteLine(c.CarName+" "+c.Description + " " +c.BrandId);
            //}
            //foreach (var c in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(c.CarName + " " + c.BrandName + " " + c.ColorName + " " +c.DailyPrice);
            //}

            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            var result = rentalManager.Add(new Rental
            {
                CarId = 4,
                CustomerId = 7,
                RentDate = new DateTime(2012, 10, 10)

            });

            Console.WriteLine(result.Messages);


            //foreach (var item in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.CarId+" "+item.ReturnDate);
            //}




        }
    }
}