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
        public readonly IMapper _mapper;

        public BookingRepository(HotelDBContext dbContext, IMapper mapper): base(dbContext)
        {
            _mapper = mapper;
        }

        public List<BookingDTO> GetBookingsByUserId(int userID)
        {
            return _mapper.Map<List<BookingDTO>>(Get(b => b.IdUser == userID));
        }
    }
}
