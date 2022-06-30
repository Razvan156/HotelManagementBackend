using AutoMapper;
using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    public class BookingRepository: BaseRepository<Booking>, IBookingRepository
    {
        public BookingRepository(HotelDBContext dbContext): base(dbContext)
        {
        }

        public List<Booking> GetBookingsByUserId(int userID)
        {
            return dbContext.Bookings.Where(b=>b.IdUser == userID).ToList();
        }
        public bool RemoveBooking(int bookingID)
        {
            Booking booking= dbContext.Bookings.Where(b => b.IdBooking == bookingID).SingleOrDefault();
            if(booking!=null)
            {
                booking.Deleted = true;
                return true;
            }
            return false;
        }
    }
}
