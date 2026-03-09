using Microsoft.Extensions.DependencyInjection;

namespace Ordering.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApllicationServices(this IServiceCollection services)
        {
            //services.AddMediatoR(cfg => {
            //      cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            //});

            return services;
        }
    }
}
