using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Repositories;

namespace Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<ITicketRepository, TicketRepository>();

            return services;
        }
    }
}
