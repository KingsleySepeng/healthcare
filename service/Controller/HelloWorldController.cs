using Microsoft.AspNetCore.Mvc;

namespace service.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // GET api/helloworld | its name of controller without Contoller suffix
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello, World!";
        }

        // POST api/helloworld
        [HttpPost]
        public ActionResult<string> Post([FromBody] string name)
        {
            return $"Hello, {name}";
        }

        // PUT api/helloworld/{id}
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string name)
        {
            return $"Updated {name} with ID {id}";
        }

        // DELETE api/helloworld/{id}
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return $"Deleted item with ID {id}";
        }
    }
}
