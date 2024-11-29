using Microsoft.Extensions.DependencyInjection;
using Repository.Repositories;
using Repository.Repositories.Interfaces;

namespace Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            services.AddScoped<ICityRepository, CityRepository>();
            // Burada digər repository-ləri də əlavə edin:
            // services.AddScoped<ICountryRepository, CountryRepository>();

            return services;
        }
    }
}