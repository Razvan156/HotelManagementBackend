using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    public class BookingRoomTypeRepository: BaseRepository<BookingRoomType>, IBookingRoomTypeRepository
    {
        public BookingRoomTypeRepository(HotelDBContext dbContext) : base(dbContext)
        {

        }
    }
}
