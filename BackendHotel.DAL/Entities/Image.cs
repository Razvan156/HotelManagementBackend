using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class Image : BaseEntity
    {
        public int IdImage { get; set; }
        public int IdRoomType { get; set; }
        public string ImagePath { get; set; }
        public bool Deleted { get; set; }

        public virtual RoomType IdRoomTypeNavigation { get; set; }
    }
}
