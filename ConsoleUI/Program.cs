using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();
            //BrandTest();
            //CarTest1();

            CarManager carManager = new CarManager(new EfCarDal());

            
            
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine($"{car.CarName} : {car.BrandName} : {car.ColorName} : {car.DailyPrice}");              
            }

        }

        private static void CarTest1()
        {
            CarManager carManager = new CarManager(new EfCarDal());

           
            foreach (var car in carManager.GetAll().Data)
            {
                if (car.CarName == "Duster")
                {
                    carManager.Update(new Car(){ColorId = 2});
                }
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand() { BrandName = "Opel" });

            foreach (var brand in brandManager.GetBrands())
            {
                Console.WriteLine(brand.BrandName + " : " + brand.Id);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetColors())
            {
                Console.WriteLine(color.ColorName);
            }
        }
    }
}
