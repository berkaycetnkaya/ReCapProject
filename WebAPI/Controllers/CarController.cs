using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        [HttpGet]
        public List<Car> Get()
        {
            ICarService carService = new CarManager(new EfCarDal());
            
            var result = carService.GetAll();
            return result.Data;
        }

    }
}
