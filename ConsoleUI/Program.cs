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
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Car car = new Car() { Id = 12, Description = "a", BrandId = 43, ColorId = 32, DailyPrice = 324, ModelYear = 1909 };
            Color color = new Color() { ColorName = "Mavi", Id = 3 };
            Brand brand = new Brand() { BrandName = "b", Id = 2 };
            Rental rental = new Rental() { Id=42,CarId =13,CustomerId=14, RendDate= DateTime.Today,ReturnDate=DateTime.Now };

            Console.WriteLine(rentalManager.Add(rental).Message);

            //Console.WriteLine(colorManager.Add(color).Message);
            //Console.WriteLine(colorManager.Delete(color).Message);


            //Console.WriteLine(carManager.Add(car).Message);
            //Console.WriteLine(brandManager.Add(brand).Message);



            Console.WriteLine("-------------------------------");
            GetById(carManager);
            Console.WriteLine("-------------------------------");
            GetAllBrands(brandManager);
            Console.WriteLine("-------------------------------");
            GetAllCars(carManager);
            Console.WriteLine("-------------------------------");
            GetAllColors(colorManager);
            Console.WriteLine("-------------------------------");
            GetCarsDetails(carManager);
            Console.WriteLine("-------------------------------");
            GetAllCustomer(customerManager);
            Console.WriteLine("-------------------------------");
            GetAllRental(rentalManager);
            Console.WriteLine("-------------------------------");

        }

        private static void GetAllBrands(BrandManager brandManager)
        {
            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
        private static void GetAllCustomer(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
        private static void GetAllRental(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RendDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void GetAllCars(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetById(CarManager carManager)
        {
            Console.WriteLine(carManager.GetById(1).Data.Description);
        }

        private static void GetCarsDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetailDto();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.DailyPrice + " " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void GetAllColors(ColorManager colorManager)
        {
            var result = colorManager.GetAll();


            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
