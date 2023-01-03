using Business.Abstract;
using Business.Homepage.Abstract;
using Entities.HomePage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Homepage
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectedNavbarController : ControllerBase
    {

        ISelectedService _selectedService;
        public SelectedNavbarController(ISelectedService selectedservice)
        {
            _selectedService = selectedservice; 

        }
       

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // dependency chain--ICarService carService = new CarManager(new EfCarDal());


            var result = _selectedService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SelectedNavbar nav)
        {
            var result = _selectedService.Delete(nav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(SelectedNavbar nav)
        {
            var result = _selectedService.Add(nav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(SelectedNavbar nav)
        {
            var result = _selectedService.Update(nav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetbyId(int id)
        {
            var result = _selectedService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

