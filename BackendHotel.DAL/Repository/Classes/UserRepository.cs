using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(HotelDBContext dbContext) : base(dbContext)
        {}

        public User GetUserByUsername(string username)
        {
            return Get(u => u.Username == username).SingleOrDefault();
        }
        public User GetUserByEmail(string email)
        {
            return Get(u => u.Email == email).SingleOrDefault();
        }
        public int GetUserId(User user)
        {
            return Get(u => u.Username == user.Username && u.Email == user.Email && u.Password == user.Password).FirstOrDefault()?.IdUser ?? -1;
        }
    }
}
