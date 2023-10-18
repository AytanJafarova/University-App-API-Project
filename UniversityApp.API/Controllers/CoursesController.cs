using BusinessLogicLayer.Abstract;
using DTO.CourseDTOs;
using DTO.DepartmentDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_courseService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_courseService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] CourseToAddDTO course)
        {
            _courseService.Add(course);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] CourseToUpdateDTO course)
        {
            _courseService.Update(id, course);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_courseService.Delete(id);  //Hard Delete
            _courseService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
