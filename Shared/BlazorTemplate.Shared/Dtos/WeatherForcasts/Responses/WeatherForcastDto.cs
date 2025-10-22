using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorTemplate.Shared.Dtos.WeatherForcasts.Responses
{
    public class WeatherForcastDto
    {
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }
}
