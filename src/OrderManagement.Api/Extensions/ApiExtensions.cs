namespace OrderManagement.Api.Extensions;

public static class ApiExtensions
{
    public static void AddApiCors(this IServiceCollection services, string allowedHosts)
    {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.WithOrigins(allowedHosts);
            });
        });
    }
}
