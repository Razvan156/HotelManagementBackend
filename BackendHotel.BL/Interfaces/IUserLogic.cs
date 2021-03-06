using BackendHotel.DAL.Entities;
using BackendHotel.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.BL.Interfaces
{
    public interface IUserLogic
    {
        Task RegisterUser(UserDTO userDTO);
        int GetUserId(UserDTO userDTO);
    }
}
