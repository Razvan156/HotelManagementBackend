using BackendHotel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Interfaces
{
    public interface IBookingRepository: IBaseRepository<Booking>
    {
        List<Booking> GetBookingsByUserId(int userID);

    }
}
