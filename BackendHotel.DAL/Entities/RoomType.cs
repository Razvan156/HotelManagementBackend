using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class RoomType : BaseEntity
    {
        public RoomType()
        {
            BookingRoomTypes = new HashSet<BookingRoomType>();
            Images = new HashSet<Image>();
            Prices = new HashSet<Price>();
            RoomTypeFeatures = new HashSet<RoomTypeFeature>();
        }

        public int IdRoomType { get; set; }
        public string RoomTypeName { get; set; }
        public int NumberOfRooms { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<BookingRoomType> BookingRoomTypes { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<RoomTypeFeature> RoomTypeFeatures { get; set; }
    }
}
