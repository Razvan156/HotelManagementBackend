using BackendHotel.DAL.Entities;
using BackendHotel.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Interfaces
{
    public interface IBookingRepository: IBaseRepository<Booking>
    {
        List<BookingDTO> GetBookingsByUserId(int userID);

    }
}
