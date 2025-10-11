using BlazorTemplate.Api.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorTemplate.Api.Endpoints;

public class WeatherForecasts : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.RequireAuthorization();

        groupBuilder.MapGet(GetWeatherForecasts);
    }
    public async Task<Ok<string[]>> GetWeatherForecasts(ISender sender)
    {
        var summaries = new[]
         {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        return TypedResults.Ok(summaries);
    }
}
