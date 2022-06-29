using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class Booking : BaseEntity
    {
        public Booking()
        {
            BookingRoomTypes = new HashSet<BookingRoomType>();
            BookingServices = new HashSet<BookingService>();
        }

        public int IdBooking { get; set; }
        public int IdUser { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set; }
        public string BookingStatus { get; set; }
        public bool Deleted { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<BookingRoomType> BookingRoomTypes { get; set; }
        public virtual ICollection<BookingService> BookingServices { get; set; }
    }
}
