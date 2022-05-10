using Microsoft.AspNetCore.Mvc;
using PatrickGod_dotnetWebAPI.Data;
using PatrickGod_dotnetWebAPI.Dtos.Character;
using PatrickGod_dotnetWebAPI.Dtos.User;
using PatrickGod_dotnetWebAPI.Models;

namespace PatrickGod_dotnetWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        //  An ActionResult is a return type of a controller method, also called an action method
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepository.Register(
                new User { Username = request.Username }, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepository.Login(
                request.Username, request.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}