using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    public class BookingServiceRepository: BaseRepository<BookingService>, IBookingServiceRepository
    {
        public BookingServiceRepository(HotelDBContext dbContext) : base(dbContext)
        {

        }
    }
}
