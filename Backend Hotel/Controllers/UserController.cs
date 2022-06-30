using Microsoft.AspNetCore.Mvc;
using BackendHotel.TL.DTO;
using System;
using System.Threading.Tasks;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.BL.Interfaces;

namespace BackendHotel.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        public IUserLogic _userLogic { get; set; }

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(UserDTO userDTO)
        {
            try
            {
                await _userLogic.RegisterUser(userDTO);
                return Ok("User registered successfully!");
            }
            catch (Exception exception)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult LoginUser(UserDTO userDTO)
        {
            try
            {
                int userId = _userLogic.GetUserId(userDTO);
                return Ok(new { message = "User login successfull!", content = userId });
            }
            catch(Exception exception)
            {
                return NotFound(exception.Message);
            }
        }
    }
}

