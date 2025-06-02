using InventoryManager.Application.DTO;
using InventoryManager.Application.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult>  LoginUser([FromBody] LoginDto login)
        {
            try
            {
                var tk = await _authService.LoginAsync(login);
                return Ok(new { tk });
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            var success = await _authService.RegisterAsync(dto);
            return success != null ? Ok(new { message = "User registered successfully",
                                              User = success} ) 
                : BadRequest("Registration failed");
        }
    }
}
