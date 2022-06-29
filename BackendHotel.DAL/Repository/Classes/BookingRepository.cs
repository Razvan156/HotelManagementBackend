using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    public class BookingRepository: BaseRepository<Booking>, IBookingRepository
    {
        public BookingRepository(HotelDBContext dbContext) : base(dbContext)
        {

        }

        public List<Booking> GetBookingsByUserId(int userID)
        {
            return Get(b => b.IdUser == userID).ToList();
        }
    }
}
