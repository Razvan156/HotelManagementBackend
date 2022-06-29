using BackendHotel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Interfaces
{
    public interface IUserRepository: IBaseRepository<User>
    {
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        public int GetUserId(User user);
    }
}
