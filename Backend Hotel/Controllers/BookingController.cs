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
    [Route("[api/booking]")]
    public class BookingController : Controller
    {
        public IBookingLogic _bookingLogic { get; set; }

        public BookingController(IBookingLogic bookingLogic)
        {
            _bookingLogic = bookingLogic;
        }

        [HttpPost("bookings")]
        public IActionResult GetBookingsByUserId(int userID)
        {
            List<BookingDTO> bookings = _bookingLogic.GetBookingByUserId(userID);
            if(bookings.Count == 0)
            {
                return Json("You have no reservations...");
            }
            return Json(bookings);
        }
    }
}


