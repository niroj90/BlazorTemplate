using BlazorTemplate.Domain;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace BlazorTemplate.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddDomainServices();
        // Register MediatR handlers from this assembly using marker type
        services.AddMediatR(typeof(DependencyInjection));
        return services;
    }
}
