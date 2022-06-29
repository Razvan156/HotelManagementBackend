using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.DAL.Repository.Classes
{
    class ServiceRepository: BaseRepository<Service>, IServiceRepository
    {
        public ServiceRepository(HotelDBContext dbContext) : base(dbContext)
        {

        }
    }
}
