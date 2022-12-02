﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // Attribute c# and annatation java
        // Loose coupled  gevşek bağımlılık
        // naming convention
        //Icarservice injection
        // javada farklı angularda dırek ctor da ver asagıda kullan
        // somut referans yok bunu cozmek için Ioc Container ile çözüüyor
        // ınversion of control  ==>   referans configurasyonu bellekte yer tutuyor kım kullanacaksa ona verıyor
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // dependency chain--ICarService carService = new CarManager(new EfCarDal());


            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);    
        }
        [HttpPost("add")]  
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyid")]
            public IActionResult GetbyId(int id)
        {
            var result = _carService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}