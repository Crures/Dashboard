using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using dashboard.context.ICommands;
using dashboard.context.IQueries;
using dashboard.context.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dashboard.Controllers
{
    [Route("api/User/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserQueries _userQueries;
        private readonly IUserCommands _userCommands;

        public UserController(IUserQueries userQueries, IUserCommands userCommands)
        {
            _userQueries = userQueries;
            _userCommands = userCommands;
        }
        // GET: api/User/
        [HttpGet]
        public List<User> Get()
        {
            var qry = _userQueries.FetchUsers();
            return qry;
        }

        // GET api/User/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var qry = _userQueries.FetchUser(id);
            return qry;
        }

        [HttpPost("authenticate")]
        public IActionResult Auth(User user)
        {
            var qry = _userQueries.Authenticate(user);
            if (qry == null)
                return NotFound("Wrong email or password");
            return Ok(qry);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post(User user)
        {
            // var cmd = _userCommands.CreateUser(user);
            // hier moet nog een http callback
            // serviceresult of actionresult
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
