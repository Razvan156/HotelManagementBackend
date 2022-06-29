using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class PriceDTO
    {
        public int IdPrice { get; set; }
        public int IdRoomType { get; set; }
        public decimal PriceValue { get; set; }
        public DateTime PriceStartDate { get; set; }
        public DateTime? PriceEndDate { get; set; }
        public bool Deleted { get; set; }

        public virtual RoomTypeDTO IdRoomTypeNavigation { get; set; }
    }
}
