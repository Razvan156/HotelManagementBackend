using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class BookingServiceDTO
    {
        public int IdBooking { get; set; }
        public int IdService { get; set; }
        public bool Deleted { get; set; }

        public virtual BookingDTO IdBookingNavigation { get; set; }
        public virtual ServiceDTO IdServiceNavigation { get; set; }
    }
}
