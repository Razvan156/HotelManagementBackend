using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class BookingService : BaseEntity
    {
        public int IdBooking { get; set; }
        public int IdService { get; set; }
        public bool Deleted { get; set; }

        public virtual Booking IdBookingNavigation { get; set; }
        public virtual Service IdServiceNavigation { get; set; }
    }
}
