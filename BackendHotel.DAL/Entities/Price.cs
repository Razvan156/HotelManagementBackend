using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class Price : BaseEntity
    {
        public int IdPrice { get; set; }
        public int IdRoomType { get; set; }
        public decimal PriceValue { get; set; }
        public DateTime PriceStartDate { get; set; }
        public DateTime? PriceEndDate { get; set; }
        public bool Deleted { get; set; }

        public virtual RoomType IdRoomTypeNavigation { get; set; }
    }
}
