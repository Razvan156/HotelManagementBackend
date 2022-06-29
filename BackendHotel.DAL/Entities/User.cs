using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class User : BaseEntity
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
        }

        public int IdUser { get; set; }
        public string UserType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
