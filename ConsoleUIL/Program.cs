using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace ConsoleUIL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal(),new GenericMessages<Color>());
            // MarkalarıGetir(brandManager);
            Color color = new Color { Name= "Turkuaz"};
            
            

            Console.WriteLine(colorManager.Add(color).Message);
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