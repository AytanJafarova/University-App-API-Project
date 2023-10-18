using BusinessLogicLayer.Abstract;
using DTO.DepartmentDTOs;
using DTO.PreExamDTOs;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreExamsController : ControllerBase
    {
        private readonly IPreExamService _preExamService;
        public PreExamsController(IPreExamService preExamService)
        {
            _preExamService = preExamService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_preExamService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_preExamService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] PreExamToAddDTO preExam)
        {
            _preExamService.Add(preExam);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] PreExamToUpdateDTO preExam)
        {
            _preExamService.Update(id, preExam);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_preExamService.Delete(id);  //Hard Delete
            _preExamService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
