using System;
using System.Collections.Generic;

#nullable disable

namespace BackendHotel.DAL.Entities
{
    public partial class Service : BaseEntity
    {
        public Service()
        {
            BookingServices = new HashSet<BookingService>();
        }

        public int IdService { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<BookingService> BookingServices { get; set; }
    }
}
