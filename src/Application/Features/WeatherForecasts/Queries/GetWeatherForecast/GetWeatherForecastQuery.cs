namespace Application.Features.WeatherForecasts.Queries.GetWeatherForecast;

using MediatR;
using System.Collections.Generic;

public class GetWeatherForecastQuery : IRequest<IEnumerable<GetWeatherForecastDTO>>
{
}