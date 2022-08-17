namespace Application.Features.WeatherForecasts.Queries.GetWeatherForecast;

using Domain;

public interface IGetWeatherForecastRepository
{
    WeatherForecast[] GenerateWeatherForecast();
}
