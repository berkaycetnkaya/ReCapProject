using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUIL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(1).Description);
           
            //foreach (var car in carManager.GetAllDto())
            //{
            //    Console.WriteLine(car.Id +" "+ car.ModelYear +" "+ car.DailyPrice +" "+ car.BrandName +" "+ car.ColorName + car.Description);
            //}
        }
    }
}