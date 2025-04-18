﻿using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, null);
        }

        [HttpPut]
        public IActionResult Put(int id)
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPut("{id:int}/profile-picture")]
        public IActionResult PutProfilePicture(int id, IFormFile file)
        {
            var description = $"file name: {file.FileName}, length: {file.Length}";

            // process file

            return Ok(description);
        }
    }
}
