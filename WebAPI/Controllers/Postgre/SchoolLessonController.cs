using Business.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Postgre
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolLessonController : ControllerBase
    {
        ISchoolLessonService _schoolLessonService;

        public SchoolLessonController(ISchoolLessonService schoolLessonService)
        {
            _schoolLessonService = schoolLessonService; 
        }
        [HttpGet("getbyid")]
        public IActionResult GetbyId(int id)
        {
            var result = _schoolLessonService.GetByID(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(SchoolLesson school)
        {
            var result = _schoolLessonService.Delete(school);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(SchoolLesson school)
        {
            var result = _schoolLessonService.Add(school);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(SchoolLesson school)
        {
            var result = _schoolLessonService.Update(school);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
