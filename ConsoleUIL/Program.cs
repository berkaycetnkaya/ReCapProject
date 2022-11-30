using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUIL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // MarkalarıGetir(brandManager);

            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach(var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/" + car.ModelYear +"/"+result.Message);
                    
                }

            }
            else
            {
                Console.WriteLine(result.Message);  
            }


            //foreach (var car in carManager.GetAllDto())
            //{
            //    Console.WriteLine(car.Id +" "+ car.ModelYear +" "+ car.DailyPrice +" "+ car.BrandName +" "+ car.ColorName + car.Description);
            //}
            



        }

        private static void MarkalarıGetir(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name + brand.Id);
            }
        }
    }
}