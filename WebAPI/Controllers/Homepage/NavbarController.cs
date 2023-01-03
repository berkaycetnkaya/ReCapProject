using Business.Abstract;
using Business.Homepage.Abstract;
using Entities;
using Entities.HomePage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Homepage
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavbarController : ControllerBase
    {
        INavbarService _navbarService;
        public NavbarController(INavbarService navbarService)
        {
            _navbarService = navbarService; 
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // dependency chain--ICarService carService = new CarManager(new EfCarDal());


            var result = _navbarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Navbar nav)
        {
            var result = _navbarService.Delete(nav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Navbar nav)
        {
            var result = _navbarService.Add(nav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Navbar nav)
        {
            var result = _navbarService.Update(nav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
