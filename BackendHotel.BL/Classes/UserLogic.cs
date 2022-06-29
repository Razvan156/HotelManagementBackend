using AutoMapper;
using BackendHotel.BL.Interfaces;
using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.BL.Classes
{
    public class UserLogic: IUserLogic
    {
        public IUserRepository _userRepository { get; set; }
        public IMapper _mapper { get; set; }
        public UserLogic(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task RegisterUser(UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            if (_userRepository.GetUserByUsername(user.Username) != null)
            {
                throw (new Exception("Error: Inserted username is taken!"));
            }
            if(_userRepository.GetUserByEmail(user.Email) != null)
            {
                throw (new Exception("Error: Inserted email is taken!"));
            }
            user.UserType = "Client";
            await _userRepository.Create(user);
        }

        public int GetUserId(UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            user.IdUser = _userRepository.GetUserId(user);
            if (user.IdUser == -1)
            {
                throw new Exception("Error: The user does not exist!");
            }
            return user.IdUser;
        }
    }
}
