using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendHotel.DAL.Entities;
using BackendHotel.TL.DTO;

namespace BackendHotel.BL.Classes.Helper
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Booking, BookingDTO>();
            CreateMap<BookingRoomType, BookingRoomTypeDTO>();
            CreateMap<BookingService, BookingServiceDTO>();
            CreateMap<Feature, FeatureDTO>();
            CreateMap<Image, ImageDTO>();
            CreateMap<Price, PriceDTO>();
            CreateMap<RoomTypeFeature, RoomTypeFeatureDTO>();
            CreateMap<RoomType, RoomTypeDTO>();
            CreateMap<Service, ServiceDTO>();
            CreateMap<User, UserDTO>();
        }
    }
}
