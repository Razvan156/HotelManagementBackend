using Microsoft.AspNetCore.Mvc;
using BackendHotel.TL.DTO;
using System;
using System.Threading.Tasks;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.BL.Interfaces;

namespace BackendHotel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        public IUserLogic _userLogic { get; set; }

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(string username, string email, string password)
        {
            try
            {
                await _userLogic.RegisterUser(username, email, password);
                return Json("User registered successfully!");
            }
            catch (Exception exception)
            {
                return Json(exception.Message);
            }
        }
    }
}

