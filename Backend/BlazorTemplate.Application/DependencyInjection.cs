using BlazorTemplate.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddDomainServices();
        return services;
    }

}
