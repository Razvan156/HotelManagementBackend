using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class RoomTypeDTO
    {
        public RoomTypeDTO()
        {
            BookingRoomTypes = new HashSet<BookingRoomTypeDTO>();
            Images = new HashSet<ImageDTO>();
            Prices = new HashSet<PriceDTO>();
            RoomTypeFeatures = new HashSet<RoomTypeFeatureDTO>();
        }

        public int IdRoomType { get; set; }
        public string RoomTypeName { get; set; }
        public int NumberOfRooms { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<BookingRoomTypeDTO> BookingRoomTypes { get; set; }
        public virtual ICollection<ImageDTO> Images { get; set; }
        public virtual ICollection<PriceDTO> Prices { get; set; }
        public virtual ICollection<RoomTypeFeatureDTO> RoomTypeFeatures { get; set; }
    }
}
