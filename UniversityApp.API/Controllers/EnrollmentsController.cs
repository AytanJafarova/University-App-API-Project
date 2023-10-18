using BusinessLogicLayer.Abstract;
using DTO.EnrollmentDTOs;
using DTO.ExamDTOs;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentsController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_enrollmentService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_enrollmentService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] EnrollmentToAddDTO enrollment)
        {
            _enrollmentService.Add(enrollment);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] EnrollmentToUpdateDTO enrollment)
        {
            _enrollmentService.Update(id, enrollment);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_enrollmentService.Delete(id);  //Hard Delete
            _enrollmentService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
