using Service.Helpers.DTOs.City;

namespace Service.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDto>> GetAllAsync();
        Task<CityDto> GetByIdAsync(int id);
        Task CreateAsync(CityCreateDto cityCreateDto);
        Task UpdateAsync(CityEditDto cityEditDto);
        Task DeleteAsync(int id);
    }
}
