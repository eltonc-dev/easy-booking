using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegisterDomain.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RegisterWeb.Controllers
{
    [ApiController]
    [Route("RoomTypes")]
    public class RoomTypesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAsync()
        {
            return Ok(new List<RoomTypeEntity>()); ;
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

