using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Domain.Repositories;
using OrderManagement.Infrastructure.Persistence.Repositories;

namespace OrderManagement.Infrastructure.Extensions;

public static class PersistanceExtension
{
    public static IServiceCollection AddPersistance(this IServiceCollection services)
    {
        services.AddScoped<IOrderRepository, OrderRepository>();
        return services;
    }
}
