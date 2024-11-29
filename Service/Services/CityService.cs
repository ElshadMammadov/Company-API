using Service.Helpers.DTOs.City;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CityService : ICityService
    {
        public Task CreateAsync(CityCreateDto cityCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CityDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CityDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CityEditDto cityEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
