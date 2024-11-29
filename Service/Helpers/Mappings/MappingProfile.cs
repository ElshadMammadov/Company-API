using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using Service.Helpers.DTOs.City;


namespace Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // City Mapping
            CreateMap<City, CityDto>()
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name));
            CreateMap<CityCreateDto, City>();
            CreateMap<CityEditDto, City>();
        }
    }
}