using Microsoft.AspNetCore.Mvc;
using BAL;
using UserService.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        ILogger<UsersController> _logger;
        UserS _user;
        public UsersController(UserS user, ILogger<UsersController> logger)
        {
            _user = user;
            _logger = logger;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public List<User> Get()
        {
            _logger.LogInformation("Inside Get Method");
            return _user.GetUsers().ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            _logger.LogInformation("Inside Get 1 Method");

            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
