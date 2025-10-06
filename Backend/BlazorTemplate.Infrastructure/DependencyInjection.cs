using Microsoft.Extensions.DependencyInjection;

namespace BlazorTemplate.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Add infrastructure services here (e.g., database context, repositories, etc.)
        return services;
    }

}
