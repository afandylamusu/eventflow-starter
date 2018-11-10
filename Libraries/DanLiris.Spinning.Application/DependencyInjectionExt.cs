using Microsoft.Extensions.Configuration;
using EventFlow.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionExt
    {
        public static void AddSpinningServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEventFlow(c => {

            });
        }
    }
}
