using JWTAuthDotNet9.Entities;
using JWTAuthDotNet9.Models;
using JWTAuthDotNet9.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthDotNet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
    
        [HttpPost("register")]

        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var user = await authService.RegisterAsync(request);
            if (user == null)
                return BadRequest("Username already exists.");

            return Ok(user);
        }


        [HttpPost("login")]

        public async Task<ActionResult<TokenResponseDto>> Login(UserDto request) 
        {
            var result = await authService.LoginAsync(request);
            if (result == null) 
                return BadRequest("Invalid username or password.");
            
            return Ok(result);                                                                                                                                                                                                                                                                                                                                                                                          
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponseDto>> RefreshToken(RefreshTokenRequestDto Request)
        {
            var result = await authService.RefreshTokenAsync(Request);
            if (result == null || result.AccessToken is null || result.RefreshToken is null)
                return Unauthorized("Invalid refresh token");

            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        public IActionResult AuthenticatedOnlyEndpoint()
        {
            return Ok("You are authenticated!");
        }


        [Authorize(Roles = "Admin")]
        [HttpGet("Admin-only")]
        public IActionResult AdminOnlyEndpoint()
        {
            return Ok("You are Admin!");
        }

    }
}
                                                                                                                                                                                                                                                            