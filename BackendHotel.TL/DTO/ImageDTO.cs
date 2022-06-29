using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class ImageDTO
    {
        public int IdImage { get; set; }
        public int IdRoomType { get; set; }
        public string ImagePath { get; set; }
        public bool Deleted { get; set; }

        public virtual RoomTypeDTO IdRoomTypeNavigation { get; set; }
    }
}
