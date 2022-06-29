using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.TL.DTO
{
    public class ServiceDTO
    {
        public int IdService { get; set; }
        public string ServiceName { get; set; }
        public decimal ServicePrice { get; set; }
        public bool Deleted { get; set; }
    }
}
