using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class BookingDTO
    {
        public BookingDTO()
        {
            BookingRoomTypes = new HashSet<BookingRoomTypeDTO>();
            BookingServices = new HashSet<BookingServiceDTO>();
        }

        public int IdBooking { get; set; }
        public int IdUser { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set; }
        public string BookingStatus { get; set; }
        public bool Deleted { get; set; }

        public virtual UserDTO IdUserNavigation { get; set; }
        public virtual ICollection<BookingRoomTypeDTO> BookingRoomTypes { get; set; }
        public virtual ICollection<BookingServiceDTO> BookingServices { get; set; }
    }
}
