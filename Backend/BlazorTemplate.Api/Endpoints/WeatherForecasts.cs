using BlazorTemplate.Api.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorTemplate.Api.Endpoints;

public class WeatherForecasts : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapGet(GetWeatherForecasts);
    }
    public async Task<Ok<IEnumerable<WeatherForcastDto>>> GetWeatherForecasts()
    {
        //var summaries = new[]
        // {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        var summaries = new List<WeatherForcastDto>
        {
            new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), TemperatureC = 23, Summary = "Warm" },
            new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), TemperatureC = 18, Summary = "Mild" },
            new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), TemperatureC = 30, Summary = "Hot" },
            new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), TemperatureC = 15, Summary = "Cool" },
            new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), TemperatureC = 10, Summary = "Chilly" }
        };

        return TypedResults.Ok(summaries.AsEnumerable());
    }
}

public class WeatherForcastDto
{
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }

}
