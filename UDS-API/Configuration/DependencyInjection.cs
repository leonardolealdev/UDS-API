using UDS.Domain.Interfaces.Repositories;
using UDS.Domain.Interfaces.Services;
using UDS.Domain.Services;
using UDS.Infra.Data.Repositories;

namespace UDS_API.Configuration
{
    public static class DependencyInjection
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IPeopleService, PeopleService>();
            services.AddTransient<IPeopleRepository, PeopleRepository>();
        }
    }
}
