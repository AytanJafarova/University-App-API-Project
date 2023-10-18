using BusinessLogicLayer.Abstract;
using DTO.AccountDTOs;
using DTO.StudentDTOs;
using DTO.TeacherDTOs;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IAccountService _accountService;
        public StudentsController(IStudentService studentService, IAccountService accountService)
        {
            _studentService = studentService;
            _accountService = accountService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_studentService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] StudentToAddDTO student)
        {
            _studentService.Add(student);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] StudentToUpdateDTO student)
        {
            _studentService.Update(id, student);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_teacherService.Delete(id);  //Hard Delete
            _studentService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
