using UDS.Domain.Interfaces.Services;
using UDS.Domain.Services;

namespace UDS_API.Configuration
{
    public static class DependencyInjection
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IPeopleService, PeopleService>();
        }
    }
}
