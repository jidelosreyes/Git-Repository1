using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Git_Programacion1.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiGitProgramacion1Controller : ControllerBase
    {
        // GET: api/ApiGitProgramacion1
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ApiGitProgramacion1/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ApiGitProgramacion1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ApiGitProgramacion1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
