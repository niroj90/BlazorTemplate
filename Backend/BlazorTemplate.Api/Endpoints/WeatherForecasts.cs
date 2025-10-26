using BlazorTemplate.Api.Infrastructure;
using BlazorTemplate.Application.WeatherForcasts.Queries.GetWeatherForecasts;
using BlazorTemplate.Shared.Dtos.Common.Requests;
using BlazorTemplate.Shared.Dtos.Common.Responses;
using BlazorTemplate.Shared.Dtos.WeatherForcasts.Responses;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTemplate.Api.Endpoints;

public class WeatherForecasts : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapPost(GetWeatherForecasts);
    }
    public async Task<Ok<PagedResultDto<WeatherForcastDto>>> GetWeatherForecasts(ISender sender,PagedRequestDto input)
    {
      var summaries = await sender.Send(new GetWeatherForcastsQuery
        {
            PageNumber = input.PageNumber,
            PageSize = input.PageSize
        });

        return TypedResults.Ok(summaries);
    }
}

