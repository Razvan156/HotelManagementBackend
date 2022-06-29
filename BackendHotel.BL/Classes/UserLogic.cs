using AutoMapper;
using BackendHotel.BL.Interfaces;
using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
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

        public async Task RegisterUser(string username, string email, string password)
        {
            User user = _userRepository.GetUserByUsername(username);
            if(user != null)
            {
                throw (new Exception("Error: Inserted username is taken!"));
            }
            user = _userRepository.GetUserByEmail(email);
            if(user != null)
            {
                throw (new Exception("Error: Inserted email is taken!"));
            }
            await _userRepository.Create();
        }
    }
}
