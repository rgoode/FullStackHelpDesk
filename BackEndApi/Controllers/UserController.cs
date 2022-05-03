using BackEndApi.Models;
using BackEndApi.Models.Ticket;
using BackEndApi.Services;
using BackEndApi.Services.DALModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public DbSet<Users> Users { get; set; }
        private readonly ITicketContext _userContext;

        public UserController(ITicketContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userContext.GetUsers();
            return Ok(_userContext.GetUsers());
        }

        [HttpGet]
        [Route("{userId}")]
        public IActionResult GetUser([FromRoute] int userId)
        {
            var user = _userContext.GetUser(userId);
            if (user != null)
            {
                return Ok(user);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{userId}")]
        public IActionResult DeleteTicket([FromRoute] int userId)
        {
            var ticket = _userContext.DeleteUser(userId);
            if (ticket == null)
            {
                return NotFound();
            }
            return Accepted();
        }

        [HttpPost]
        public IActionResult AddTicket([FromBody] PostUserRequest postUserRequest)
        {
            var user = new Users();
            user.UserName = postUserRequest.UserName;

            var dbTicket = _userContext.AddUser(user);
            return Created("I made you", dbTicket);
        }

        [HttpPut]
        [Route("{userId}")]
        public IActionResult UpdateTicket([FromBody] PostUserRequest postUserRequest, [FromRoute] int userId)
        {
            var user = new Users();
            user.UserName = postUserRequest.UserName;

            var dbUser = _userContext.UpdateUser(user, userId);

            if (dbUser == null)
            {
                return NotFound($"{nameof(userId)}: {userId} does not exist");
            }

            return Created($"https://localhost:5001/{dbUser.Id}", dbUser);
        }

    }
}
