using BusinessLogicLayer.Abstract;
using DTO.DepartmentDTOs;
using DTO.TeacherDTOs;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_teacherService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_teacherService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] TeacherToAddDTO teacher)
        {
            _teacherService.Add(teacher);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] TeacherToUpdateDTO teacher)
        {
            _teacherService.Update(id, teacher);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_teacherService.Delete(id);  //Hard Delete
            _teacherService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
