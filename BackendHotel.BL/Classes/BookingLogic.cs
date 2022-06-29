using AutoMapper;
using BackendHotel.BL.Interfaces;
using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.BL.Classes.Helper
{
    public class BookingLogic : IBookingLogic
    {
        public IBookingRepository _bookingRepository { get; set; }
        public IBookingRoomTypeRepository _bookingRoomTypeRepository { get; set; }
        public IMapper _mapper { get; set; }
        public BookingLogic(IBookingRepository bookingRepository, IBookingRoomTypeRepository bookingRoomTypeRepository,IMapper mapper)
        {
            _bookingRepository = bookingRepository;
            _bookingRoomTypeRepository = bookingRoomTypeRepository;
            _mapper = mapper;
        }

        public List<BookingDTO> GetBookingByUserId(int userID)
        {
            List<BookingDTO> bookingList = _mapper.Map<List<BookingDTO>>(_bookingRepository.GetBookingsByUserId(userID));
            List<BookingRoomType> bookingRoomTypeList = _bookingRoomTypeRepository.GetAll().ToList();
            foreach(var item in bookingRoomTypeList)
            {
                var booking = bookingList.Where(b => b.IdBooking == item.IdBooking).SingleOrDefault();
                if(booking != null)
                {
                    booking.TotalRoomCount += item.NumberOfRooms;
                }
                
            }
            return bookingList;
        }
    }
}
