using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace API.Controllers
{
    [Route("student")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        public StudentController(StudentService service) 
        {
            Service = service;
        }

        public StudentService Service { get; set; }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Student student) 
        {
            var product = await Service.Create(student);
            return Ok(student);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Read(Guid id)
        {
            var product = await Service.Read(id);
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]Student student)
        {

            var product = await Service.Update(student);
            return Ok(student);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute]Guid id)
        {

            var product = await Service.Delete(id);
            return Ok(product);
        }



    }
}