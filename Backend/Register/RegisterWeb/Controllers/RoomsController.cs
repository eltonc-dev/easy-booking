using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace RegisterWeb.Controllers
{
    [ApiController]
    [Route("Rooms")]
    public class RoomsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new List<string>());
        }

        [HttpPost]
        public IActionResult Save()
        {
            return Ok(new List<string>());
        }

        [Route("{id}")]
        [HttpPut]
        public IActionResult Edit(string id)
        {
            return Ok(new List<string>());
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(string id)
        {
            return Ok(new List<string>());
        }
    }
}

