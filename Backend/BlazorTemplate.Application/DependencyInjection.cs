using BlazorTemplate.Domain;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace BlazorTemplate.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddDomainServices();
        // Register MediatR handlers from this assembly
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
