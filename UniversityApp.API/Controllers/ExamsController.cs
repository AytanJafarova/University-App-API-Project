using BusinessLogicLayer.Abstract;
using DTO.DepartmentDTOs;
using DTO.ExamDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_examService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_examService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] ExamToAddDTO exam)
        {
            _examService.Add(exam);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] ExamToUpdateDTO exam)
        {
            _examService.Update(id, exam);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_examService.Delete(id);  //Hard Delete
            _examService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
