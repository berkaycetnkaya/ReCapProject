using Business.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Postgre
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
    
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            // dependency chain--ICarService carService = new CarManager(new EfCarDal());


            var result = _lessonService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Lesson lesson)
        {
            var result = _lessonService.Delete(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Lesson lesson)
        {
            var result = _lessonService.Add(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(Lesson lesson)
        {
            var result = _lessonService.Update(lesson);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetbyId(int id)
        {
            var result = _lessonService.GetByID(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
