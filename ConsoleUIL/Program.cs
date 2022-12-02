using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities;
using System.Xml.XPath;

namespace ConsoleUIL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            // MarkalarıGetir(brandManager);
            Color color = new Color { Id= 5};

            var result = carManager.GetByColorId(1);

            Console.WriteLine(result.Data + "rengi"+ result.Message);
            //foreach (var car in carManager.GetAllDto())
            //{
            //    Console.WriteLine(car.Id +" "+ car.ModelYear +" "+ car.DailyPrice +" "+ car.BrandName +" "+ car.ColorName + car.Description);
            //}
            



        }

        private static void MarkalarıGetir(BrandManager brandManager)
        {
            
        }
    }
}