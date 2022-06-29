using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class BookingRoomTypeDTO
    {
        public int IdBooking { get; set; }
        public int IdRoomType { get; set; }
        public int NumberOfRooms { get; set; }
        public int? IdDeal { get; set; }
        public bool Deleted { get; set; }

        public virtual BookingDTO IdBookingNavigation { get; set; }
        public virtual DealDTO IdDealNavigation { get; set; }
        public virtual RoomTypeDTO IdRoomTypeNavigation { get; set; }
    }
}
