using BusinessLogicLayer.Abstract;
using DTO.ExamDTOs;
using DTO.GradeDTOs;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IGradeService _gradeService;
        public GradesController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_gradeService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_gradeService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] GradeToAddDTO grade)
        {
            _gradeService.Add(grade);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] GradeToUpdateDTO grade)
        {
            _gradeService.Update(id, grade);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_gradeService.Delete(id);  //Hard Delete
            _gradeService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
