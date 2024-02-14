using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TODOLIST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskList : ControllerBase
    {
        static List<Task> tasks = new List<Task>();
        // GET: api/<TaskList>
        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return tasks;
        }

        // GET api/<TaskList>/5
        [HttpGet("{id}")]
        public Task Get(int id)
        {
            return tasks.FirstOrDefault(t => t.id == id);
        }

        // POST api/<TaskList>
        [HttpPost]
        public void Post([FromBody] Task value)
        {
            tasks.Add(value);
        }

        // PUT api/<TaskList>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Task value)
        {
            int i = tasks.FindIndex(t => t.id == id);
            if (i >= 0)
                tasks[i] = value;
        }

        // DELETE api/<TaskList>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tasks.RemoveAll(t => t.id == id);
        }
    }
}
