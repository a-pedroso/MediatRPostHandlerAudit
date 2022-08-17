namespace Infrastructure.Repositories;

using Application.Features.WeatherForecasts.Queries.GetWeatherForecast;
using Domain;
using System;
using System.Linq;

public class GetWeatherForecastRepository : IGetWeatherForecastRepository
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecast[] GenerateWeatherForecast()
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            Summaries[Random.Shared.Next(Summaries.Length)]
        ))
        .ToArray();

        return forecast;
    }
}
