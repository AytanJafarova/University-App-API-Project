using BusinessLogicLayer.Abstract;
using DTO.DepartmentDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_departmentService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_departmentService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] DepartmentToAddDTO department)
        {
            _departmentService.Add(department);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] DepartmentToUpdateDTO department)
        {
            _departmentService.Update(id, department);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_departmentService.Delete(id);  //Hard Delete
            _departmentService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
