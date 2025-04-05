using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/v1/projects")]
    public class ProjectsController(IOptions<FreelanceTotalCostConfig> options) : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _options = options.Value;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{search}")]
        public IActionResult Get(string search)
        {
            return Ok();
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            if (model.TotalCost < _options.Minimum || model.TotalCost > _options.Maximum)
                return BadRequest("Invalid value for total cost");

            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPut("{id:int}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id:int}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        [HttpPost("{id:int}/comments")]
        public IActionResult CreateComment(int id, CreateProjectCommentInputModel model)
        {
            return NoContent();
        }
    }
}
