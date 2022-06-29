using AutoMapper;
using BackendHotel.BL.Interfaces;
using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.BL.Classes.Helper
{
    public class BookingLogic : IBookingLogic
    {
        public IBookingRepository _userRepository { get; set; }
        public IMapper _mapper { get; set; }
        public BookingLogic(IBookingRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
    }
}
