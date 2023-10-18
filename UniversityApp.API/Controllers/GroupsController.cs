using BusinessLogicLayer.Abstract;
using DTO.CourseDTOs;
using DTO.GroupDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupsController(IGroupService groupService)
        {
            _groupService = groupService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_groupService.Get());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_groupService.Get(id));
        }
        [HttpPost]
        public IActionResult Add([FromBody] GroupToAddDTO group)
        {
            _groupService.Add(group);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] GroupToUpdateDTO group)
        {
            _groupService.Update(id, group);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_groupService.Delete(id);  //Hard Delete
            _groupService.SoftDelete(id); // Soft Delete
            return Ok();
        }
    }
}
