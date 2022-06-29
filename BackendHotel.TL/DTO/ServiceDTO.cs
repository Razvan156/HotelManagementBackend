using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class ServiceDTO
    {
        public ServiceDTO()
        {
            BookingServices = new HashSet<BookingServiceDTO>();
        }

        public int IdService { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<BookingServiceDTO> BookingServices { get; set; }
    }
}
