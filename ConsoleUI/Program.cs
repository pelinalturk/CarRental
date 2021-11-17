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
            // CarManager carManager = AddCar();

            //AddColor();
            //AddBrand();
            //foreach (var car in carManager.GetCarsByColorId(3))
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.
           
            CarManager carManager = new CarManager(new EfCarDal());
            // carManager.Delete(new Car {Id=2, BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Deneme", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Update(new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 350, Description = "Güncellendi", ModelYear = new DateTime(2011, 05, 13) });
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Add(new Brand { Name = "Honda" });
            brandManager.Add(new Brand { Name = "Bmw" });
            brandManager.Add(new Brand { Name = "Mercedes" });
            brandManager.Add(new Brand { Name = "Audi" });
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Name = "Beyaz" });
            colorManager.Add(new Color { Name = "Siyah" });
            colorManager.Add(new Color { Name = "Kırmızı" });
            colorManager.Add(new Color { Name = "Lacivert" });
        }

        private static CarManager AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Deneme", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 300, Description = "Deneme", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 300, Description = "Deneme 2", ModelYear = new DateTime(2010, 04, 12) });
            carManager.Add(new Car { BrandId = 1, ColorId = 3, DailyPrice = 300, Description = "Deneme 3", ModelYear = new DateTime(2010, 04, 12) });
            return carManager;
        }
    }
}
