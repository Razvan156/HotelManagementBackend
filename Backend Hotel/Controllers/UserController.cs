using Microsoft.AspNetCore.Mvc;
using BackendHotel.TL.DTO;
using System;
using System.Threading.Tasks;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.BL.Interfaces;

namespace BackendHotel.Controllers
{
    [Route("api/User")]
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
                return Json("User registered successfully!");
            }
            catch (Exception exception)
            {
                    return Json(exception.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult LoginUser(UserDTO userDTO)
        {
            try
            {
                _userLogic.GetUserId(userDTO);
                return Json(new { message = "User login successfull!", content = userDTO.IdUser });
            }
            catch(Exception exception)
            {
                return Json(exception.Message);
            }
        }
    }
}

