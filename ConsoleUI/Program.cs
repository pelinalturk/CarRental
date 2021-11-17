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
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Deneme", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Deneme", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "Deneme 2", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Add(new Car { BrandId = 1, ColorId = 3, DailyPrice = 300, Description = "Deneme 3", ModelYear = new DateTime(2010, 04, 12) });

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Name = "Beyaz" });
            colorManager.Add(new Color { Name = "Siyah" });
            colorManager.Add(new Color { Name = "Kırmızı" });
            colorManager.Add(new Color { Name = "Lacivert" });
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Add(new Brand { Name = "Bmw" });
            brandManager.Add(new Brand { Name = "Mercedes" });
            brandManager.Add(new Brand { Name = "Audi" });
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
