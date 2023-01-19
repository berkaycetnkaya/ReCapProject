using Business.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Postgre
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {

        ICityService _cityService;

        public CityController(ICityService cityService    )
        {
            _cityService= cityService;  
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // dependency chain--ICarService carService = new CarManager(new EfCarDal());


            var result = _cityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(City city)
        {
            var result = _cityService.Delete(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(City city)
        {
            var result = _cityService.Add(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(City    city)
        {
            var result = _cityService.Update(city);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetbyId(int id)
        {
            var result = _cityService.GetByID(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
