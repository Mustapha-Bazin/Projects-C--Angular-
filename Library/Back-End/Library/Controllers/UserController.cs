using BL.User;
using DTO.User;
using Interfaces.BL;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL user;
        public UserController(IUserBL _user) { 
            this.user = _user;
        }


        // GET: api/<UserController>
        [HttpGet("Get/Users")]
        [ProducesResponseType(typeof(List<UserDTO>),(int)HttpStatusCode.OK )]
        public async Task<IActionResult> GetAllUsers()
        {
            var users= await user.GetAllUsers();
            return Ok(users);
        }

        // POST api/<UserController>
        [HttpPost("Add/User")]
        public async Task<IActionResult> Post([FromBody] UserDTO _user)
        {
            
            if (_user == null) {
                return BadRequest();
            }
            var responce= await this.user.AddUser(_user);
            return Ok(responce);
        }

        
        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        /*

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
