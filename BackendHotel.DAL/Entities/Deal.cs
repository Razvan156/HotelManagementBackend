using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class Deal : BaseEntity
    {
        public Deal()
        {
            BookingRoomTypes = new HashSet<BookingRoomType>();
        }

        public int IdDeal { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public DateTime DealStartDate { get; set; }
        public DateTime DealEndDate { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<BookingRoomType> BookingRoomTypes { get; set; }
    }
}
