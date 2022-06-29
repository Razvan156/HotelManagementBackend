using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class RoomTypeFeature : BaseEntity
    {
        public int IdRoomType { get; set; }
        public int IdFeature { get; set; }
        public bool Deleted { get; set; }

        public virtual Feature IdFeatureNavigation { get; set; }
        public virtual RoomType IdRoomTypeNavigation { get; set; }
    }
}
