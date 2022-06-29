using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class BookingRoomType : BaseEntity
    {
        public int IdBooking { get; set; }
        public int IdRoomType { get; set; }
        public int NumberOfRooms { get; set; }
        public int? IdDeal { get; set; }
        public bool Deleted { get; set; }

        public virtual Booking IdBookingNavigation { get; set; }
        public virtual Deal IdDealNavigation { get; set; }
        public virtual RoomType IdRoomTypeNavigation { get; set; }
    }
}
