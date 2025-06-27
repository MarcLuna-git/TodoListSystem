using Microsoft.AspNetCore.Mvc;
using ToDoListProcess.Common;
using ToDoListProcess.DL;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DbUserManager userManager;

        public UserController()
        {
            userManager = new DbUserManager(); 
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            bool success = userManager.Register(user.Username, user.Password);
            if (!success)
                return Conflict("Username already exists.");

            return Ok("Registration successful.");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            bool authenticated = userManager.Authenticate(user.Username, user.Password);
            if (!authenticated)
                return Unauthorized("Invalid username or password.");

            return Ok("Login successful.");
        }
    }
}
