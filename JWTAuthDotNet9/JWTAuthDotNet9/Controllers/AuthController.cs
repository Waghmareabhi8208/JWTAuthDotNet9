using JWTAuthDotNet9.Entities;
using JWTAuthDotNet9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthDotNet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]

        public ActionResult<User> Register(UserDto request)
        {
            var hashedPassword = 
        }
    }
}
