using FluentValidation;
using OrderManagement.Application.Interfaces;
using OrderManagement.Application.Services;
using OrderManagement.Application.Validators;

namespace OrderManagement.Api.Extensions;

public static class ApplicationServicesExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Add application services here
        services.AddValidatorsFromAssemblyContaining<OrderDtoValidator>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddTransient<IOrderService, OrderService>();

        return services;
    }
}
