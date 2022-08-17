namespace Application.Features.WeatherForecasts.Queries.GetWeatherForecast;

using System;

public record GetWeatherForecastDTO(
    DateTime Date,
    int TemperatureC,
    int TemperatureF,
    string? Summary);