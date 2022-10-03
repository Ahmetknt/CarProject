using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //Car car = new Car() { Id = 12, Description = "a", BrandId = 43, ColorId = 32, DailyPrice = 324, ModelYear = 1909 };
            //Color color = new Color() { ColorName = "a", Id = 1 };
            //Brand brand = new Brand() { BrandName = "b", Id = 2 };
            //colorManager.Add(color);
            //carManager.Add(car);
            //brandManager.Add(brand);


            GetAllBrands(brandManager);
            Console.WriteLine("-------------------------------");
            GetAllCars(carManager);
            Console.WriteLine("-------------------------------");
            GetAllColors(colorManager);
            Console.WriteLine("-------------------------------");
            GetCarsDetails(carManager);

        }

        private static void GetAllBrands(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void GetAllCars(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetCarsDetails(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetailDto())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " "+ car.DailyPrice + " "+ car.ColorName);
            }
        }

        private static void GetAllColors(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }
    }
}
