using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class UserDTO
    {
        public UserDTO()
        {
            Bookings = new HashSet<BookingDTO>();
        }

        public int IdUser { get; set; }
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public string Email { get; set; }

        public virtual ICollection<BookingDTO> Bookings { get; set; }
    }
}
