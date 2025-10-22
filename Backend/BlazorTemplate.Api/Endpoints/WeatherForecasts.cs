using BlazorTemplate.Api.Infrastructure;
using BlazorTemplate.Application.WeatherForcasts.Queries.GetWeatherForecasts;
using BlazorTemplate.Shared.Dtos.Common.Requests;
using BlazorTemplate.Shared.Dtos.Common.Responses;
using BlazorTemplate.Shared.Dtos.WeatherForcasts.Responses;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorTemplate.Api.Endpoints;

public class WeatherForecasts : EndpointGroupBase
{
     private readonly IMediator _mediator;
    public WeatherForecasts(IMediator mediator)
    {
        _mediator = mediator;
    }
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapGet(GetWeatherForecasts);
    }
    public async Task<Ok<PagedResultDto<WeatherForcastDto>>> GetWeatherForecasts(PagedRequestDto input)
    {
      var summaries = await _mediator.Send(new GetWeatherForcastsQuery
        {
            PageNumber = input.PageNumber,
            PageSize = input.PageSize
        });

        return TypedResults.Ok(summaries);
    }
}

