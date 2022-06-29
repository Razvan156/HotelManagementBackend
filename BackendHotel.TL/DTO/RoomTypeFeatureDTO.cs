using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class RoomTypeFeatureDTO
    {
        public int IdRoomType { get; set; }
        public int IdFeature { get; set; }
        public bool Deleted { get; set; }

        public virtual FeatureDTO IdFeatureNavigation { get; set; }
        public virtual RoomTypeDTO IdRoomTypeNavigation { get; set; }
    }
}
