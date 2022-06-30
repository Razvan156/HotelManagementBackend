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
    [Route("api/booking")]
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
            try
            {
                List<BookingDTO> bookings = _bookingLogic.GetBookingByUserId(userID);
                return Ok(bookings);
            }
            catch(Exception exception)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete]
        public IActionResult RemoveBooking(int bookingID)
        {
            try
            {
                _bookingLogic.RemoveBooking(bookingID);
                return Ok("The booking has been deleted!");
            }
            catch(Exception exception)
            {
                return NotFound(exception.Message);
            }
        }
    }
}


