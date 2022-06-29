using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class BookingDTO
    {
        public int IdBooking { get; set; }
        public int IdUser { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set; }
        public string BookingStatus { get; set; }
        public bool Deleted { get; set; }
    }
}
