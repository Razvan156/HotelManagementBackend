using Microsoft.AspNetCore.Mvc;
using BackendHotel.TL.DTO;
using System;
using System.Threading.Tasks;
using BackendHotel.DAL.Repository.Interfaces;
using BackendHotel.BL.Interfaces;
using BackendHotel.DAL.Entities;
using System.Collections.Generic;

namespace BackendHotel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : Controller
    {
        public IBookingRepository _bookingRepository { get; set; }

        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public IActionResult GetBookingsByUserId(int userID)
        {
            List<BookingDTO> bookings = _bookingRepository.GetBookingsByUserId(userID);
            if(bookings.Count == 0)
            {
                return Json("You have no reservations...");
            }
            return Json(bookings);
        }
    }
}


