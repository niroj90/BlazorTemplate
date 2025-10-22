using BlazorTemplate.Shared.Dtos.Common.Requests;
using BlazorTemplate.Shared.Dtos.Common.Responses;
using BlazorTemplate.Shared.Dtos.WeatherForcasts.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTemplate.Application.WeatherForcasts.Queries.GetWeatherForecasts
{
    public class GetWeatherForcastsQuery : PagedRequestDto , IRequest<PagedResultDto<WeatherForcastDto>>;
    public class GetWeatherForcastsHandler : IRequestHandler<GetWeatherForcastsQuery, PagedResultDto<WeatherForcastDto>>
    {
        public async Task<PagedResultDto<WeatherForcastDto>> Handle(GetWeatherForcastsQuery request, CancellationToken cancellationToken)
        {
            var summaries = new List<WeatherForcastDto>
            {
                new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), TemperatureC = 23, Summary = "Warm" },
                new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), TemperatureC = 18, Summary = "Mild" },
                new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), TemperatureC = 30, Summary = "Hot" },
                new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), TemperatureC = 15, Summary = "Cool" },
                new WeatherForcastDto { Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), TemperatureC = 10, Summary = "Chilly" }
            };
            return new PagedResultDto<WeatherForcastDto>
            {
                Items = summaries,
                TotalRecordCount = summaries.Count
            };
        }
    }
}
