using AutoMapper;
using Domain.Entities;
using Service.Helpers.DTOs.City;


namespace Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<City, CityDto>();
                //.ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name));
            CreateMap<CityCreateDto, City>();
            CreateMap<CityEditDto, City>();
        }
    }
}