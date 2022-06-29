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
            CreateMap<Booking, BookingDTO>().ReverseMap();
            CreateMap<BookingRoomType, BookingRoomTypeDTO>().ReverseMap();
            CreateMap<BookingService, BookingServiceDTO>().ReverseMap();
            CreateMap<Feature, FeatureDTO>().ReverseMap();
            CreateMap<Image, ImageDTO>().ReverseMap();
            CreateMap<Price, PriceDTO>().ReverseMap();
            CreateMap<RoomTypeFeature, RoomTypeFeatureDTO>().ReverseMap();
            CreateMap<RoomType, RoomTypeDTO>().ReverseMap();
            CreateMap<Service, ServiceDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
