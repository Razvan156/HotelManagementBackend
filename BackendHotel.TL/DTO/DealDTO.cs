using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class DealDTO
    {
        public DealDTO()
        {
            BookingRoomTypes = new HashSet<BookingRoomTypeDTO>();
        }

        public int IdDeal { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public DateTime DealStartDate { get; set; }
        public DateTime DealEndDate { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<BookingRoomTypeDTO> BookingRoomTypes { get; set; }
    }
}
