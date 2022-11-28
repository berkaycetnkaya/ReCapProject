using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUIL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
        }
    }
}