using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class RoomTypeDTO
    {
        public int IdRoomType { get; set; }
        public string RoomTypeName { get; set; }
        public int NumberOfRooms { get; set; }
        public bool Deleted { get; set; }
    }
}
